using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using Twitterizer.Core;
using Twitterizer;
using Twitterizer.Streaming;

namespace TweetdeckSucks
{
  public partial class FormDeck : Form
  {
    public decimal tw_idInReplyTo = 0;
    public string tw_strMediaFilename = "";

    public FormDeck()
    {
      InitializeComponent();

      Application.AddMessageFilter(Global.messageFilter);
    }

    private void FormDeck_FormClosed(object sender, FormClosedEventArgs e)
    {
      if (Global.Settings.GetString("api_token") != "") {
        Application.Exit();
      }
    }

    public void UpdateMediaGroupBoxes()
    {
      if (groupMedia.Visible) {
        groupTweet.Width = groupMedia.Left - 12;
      } else {
        groupTweet.Width = groupTweet.Parent.Width - 12;
      }
    }

    /// <summary>
    /// Set "columns" settings in Global.Settings, you HAVE to call Global.Settings.Save() after!!
    /// </summary>
    public void SetSettingsColumns()
    {
      string strColumns = "";
      for (int i = 0; i < flowColumns.Controls.Count; i++) {
        ColumnControl cc = (ColumnControl)flowColumns.Controls[i];
        string strColumnType = cc.ColType.ToString();
        string strColumnMeta = cc.ListLocation;
        strColumns += strColumnType + ":" + strColumnMeta + ",";
      }
      Global.Settings.SetString("columns", strColumns.Trim(','));
    }

    private void FormDeck_Load(object sender, EventArgs e)
    {
      UpdateMediaGroupBoxes();

      bool bFirstStart = !Global.Settings.GetBool("started");
      int iWidth = Global.Settings.GetInt("deck_width");
      int iHeight = Global.Settings.GetInt("deck_height");
      int iLeft = Global.Settings.GetInt("deck_left");
      int iTop = Global.Settings.GetInt("deck_top");

      if (iWidth != 0 && iHeight != 0) {
        this.Width = iWidth;
        this.Height = iHeight;
        this.Left = iLeft;
        this.Top = iTop;
      }

      // on first startup
      if (bFirstStart) {
        // add some predefined columns
        ColumnControl ccTimeline = new ColumnControl();
        ccTimeline.SetColumnType(ColumnType.Timeline, "");
        flowColumns.Controls.Add(ccTimeline);

        ColumnControl ccMentions = new ColumnControl();
        ccMentions.SetColumnType(ColumnType.Mentions, "");
        flowColumns.Controls.Add(ccMentions);

        ColumnControl ccDirectMessages = new ColumnControl();
        ccDirectMessages.SetColumnType(ColumnType.DirectMessages, "");
        flowColumns.Controls.Add(ccDirectMessages);

        Global.Settings.SetBool("started", true);
        SetSettingsColumns();
        Global.Settings.Save();
      } else {
        // load columns from config
        string[] astrColumns = Global.Settings.GetString("columns").Split(',');
        for (int i = 0; i < astrColumns.Length; i++) {
          string[] astrColumnInfo = astrColumns[i].Split(':');

          string strColumnType = astrColumnInfo[0];
          string strColumnMeta = astrColumnInfo[1];

          ColumnControl cc = new ColumnControl();
          cc.SetColumnType(strColumnType, strColumnMeta);
          flowColumns.Controls.Add(cc);
          cc.Height = flowColumns.Height - 3;
        }
      }

      if (Global.ThisUser != null) {
        Global.DownloadImageToPictureBox(picUserAvatar, Global.ThisUser.ProfileImageSecureLocation, this);
        labelUserName.Text = "@" + Global.ThisUser.ScreenName;

        // load initial tweets for all columns
        for (int i = 0; i < flowColumns.Controls.Count; i++) {
          ColumnControl cc = (ColumnControl)flowColumns.Controls[i];
          cc.DownloadInitialTweets();
        }
      }

      StartStreaming();
    }

    public void InsertTweetIn(TwitterStatus tweet, ColumnType colType)
    {
      for (int i = 0; i < flowColumns.Controls.Count; i++) {
        ColumnControl cc = (ColumnControl)flowColumns.Controls[i];
        if (cc.ColType == colType) {
          cc.InsertTweet(cc.flowColumn, tweet);
        }
      }
    }

    public void InsertDMIn(TwitterDirectMessage dm, ColumnType colType)
    {
      for (int i = 0; i < flowColumns.Controls.Count; i++) {
        ColumnControl cc = (ColumnControl)flowColumns.Controls[i];
        if (cc.ColType == colType) {
          cc.InsertDM(cc.flowColumn, dm);
        }
      }
    }

    public void ShowInlineUserInfo(string strUsername)
    {
      // TODO: Make an inline user info thing
      MessageBox.Show(strUsername);
    }

    public void ShowInlineConversation(decimal idTweet)
    {
      // TODO: Make an inline conversation viewer thing
      MessageBox.Show(idTweet.ToString());
    }

    public void ShowHashtagInfo(string strHashtag)
    {
      // TODO: Make a new column with hashtag (and restart streaming [this should actually be done on column creation or destruction] so we can follow the hashtag as well)
      MessageBox.Show(strHashtag);
    }

    public void StartStreaming()
    {
      TwitterIdCollection followingIDs = null; // TODO: This could update mid-session.. NOTE!!!!111oneone (EventCallback maybe?)
      StreamOptions streamOptions = new StreamOptions();

      Global.Streaming = new TwitterStream(Global.requestToken, "", streamOptions);
      // override the default Twitterizer user agent, which is "Twitterizer/<version>", because we're assholes :D
      Global.Streaming.GetType().GetField("userAgent", (System.Reflection.BindingFlags)65535).SetValue(Global.Streaming, "TweetDeck Sucks / 0.01 / tds@angelog.nl");

      Global.Streaming.StartUserStream(new InitUserStreamCallback((TwitterIdCollection ee) => {
        followingIDs = ee;
      }), new StreamStoppedCallback((StopReasons stopReason) => {
        Console.WriteLine("StreamStoppedCallback : " + stopReason.ToString());

      }), new StatusCreatedCallback((TwitterStatus tweet) => {
        // if user is following
        if (followingIDs.Contains(tweet.User.Id)) {
          // show in timeline columns
          InsertTweetIn(tweet, ColumnType.Timeline);
        }

        // if user is being mentioned
        if (tweet.Text.ToLower().Contains("@" + Global.ThisUser.ScreenName.ToLower())) {
          // show in mentions columns
          InsertTweetIn(tweet, ColumnType.Mentions);
        }
      }), new StatusDeletedCallback((TwitterStreamDeletedEvent ee) => {
        foreach (ColumnControl cc in flowColumns.Controls) {
          foreach (TweetControl tc in cc.flowColumn.Controls) {
            if (tc.Tweet != null && tc.Tweet.Id == ee.Id) {
              tc.MarkDeleted();
            }
          }
        }
      }), new DirectMessageCreatedCallback((TwitterDirectMessage dm) => {
        InsertDMIn(dm, ColumnType.DirectMessages);
      }), new DirectMessageDeletedCallback((TwitterStreamDeletedEvent ee) => {
        foreach (ColumnControl cc in flowColumns.Controls) {
          foreach (TweetControl tc in cc.flowColumn.Controls) {
            if (tc.DM != null && tc.DM.Id == ee.Id) {
              tc.MarkDeleted();
            }
          }
        }
      }), new EventCallback((TwitterStreamEvent ee) => {
        Console.WriteLine("EventCallback");

      }));
    }

    private void textTweet_Enter(object sender, EventArgs e)
    {
      if (textTweet.Text == "What's happening?") {
        textTweet.Text = "";
        textTweet.ForeColor = Color.White;
      }
    }

    private void textTweet_Leave(object sender, EventArgs e)
    {
      if (textTweet.Text == "") {
        textTweet.Text = "What's happening?";
        textTweet.ForeColor = Color.FromArgb(126, 126, 126);
      }
    }

    private void textTweet_KeyPress(object sender, KeyPressEventArgs e)
    {
      // enter -> tweet (without ctrl!)
      if (e.KeyChar == (char)Keys.Enter) {
        if (ModifierKeys != Keys.Control) {
          buttonUpdate_Click(null, null);
          e.Handled = true;
        }
      }

      // Ctrl+Backspace (apparantly is F16..)
      if (e.KeyChar == (char)Keys.F16) {
        string strBeforeCursor = textTweet.Text.Substring(0, textTweet.SelectionStart);
        string strAfterCursor = textTweet.Text.Substring(textTweet.SelectionStart);

        int ctRemoveCharacters = 0;
        bool bFoundCharacters = false;
        for (int i = strBeforeCursor.Length - 1; i >= 0; i--) {
          char c = strBeforeCursor[i];

          if (c != ' ') {
            bFoundCharacters = true;
          }

          if (bFoundCharacters && c == ' ') {
            break;
          }

          ctRemoveCharacters++;
        }

        int iSelStart = textTweet.SelectionStart;
        textTweet.Text = strBeforeCursor.Substring(0, strBeforeCursor.Length - ctRemoveCharacters) + strAfterCursor;
        textTweet.SelectionStart = iSelStart - ctRemoveCharacters;

        e.Handled = true;
      }
    }

    public int GetTweetLength()
    {
      if (textTweet.Text == "What's happening?") {
        return 0;
      }

      return textTweet.Text.Replace("\r", "").Length;
    }

    public void ShowError(string strError)
    {
      labelError.Visible = true;
      labelError.Text = strError;

      if (timerError.Enabled) {
        // reset timer (hopefully)
        timerError.Enabled = false;
      }
      timerError.Enabled = true;
    }

    public void TweetFailure(string strContent)
    {
      string strError = strContent.Split(new string[] { "\"message\":\"", "\",\"code\"", "\"}]}" }, StringSplitOptions.None)[1];
      this.Invoke(new Action(delegate
      {
        ShowError(strError);

        textTweet.Enabled = true;
        textTweet.Focus();

        buttonUpdate.Enabled = true;
      }));
    }

    private void buttonUpdate_Click(object sender, EventArgs e)
    {
      buttonUpdate.Enabled = false;
      textTweet.Enabled = false;
      checkMedia.Enabled = false;

      string strTweet = textTweet.Text.Replace("\r", "");

      if (strTweet[0] == 'D') {
        string[] astrDMParts = strTweet.Split(new char[] { ' ' }, 3);
        if (astrDMParts.Length == 3 && astrDMParts[0] == "D") {
          TwitterDirectMessageAsync.Send(Global.requestToken, astrDMParts[1], astrDMParts[2], null, TimeSpan.FromSeconds(30), (TwitterAsyncResponse<TwitterDirectMessage> ee) => {
            if (ee.ResponseObject == null) {
              TweetFailure(ee.Content);
              return;
            }

            // NOTE: This is not required, as it comes in with streaming. I don't know why. Seriously, what?
            //InsertDMIn(ee.ResponseObject, ColumnType.DirectMessages);

            this.Invoke(new Action(delegate
            {
              textTweet.Enabled = true;
              textTweet.Text = "";
              textTweet.Focus();

              buttonUpdate.Enabled = true;
            }));
          });
          return;
        }
      }

      StatusUpdateOptions sup = new StatusUpdateOptions();
      sup.InReplyToStatusId = tw_idInReplyTo;

      if (tw_strMediaFilename != "") {
        TwitterStatusAsync.UpdateWithMedia(Global.requestToken, strTweet, tw_strMediaFilename, TimeSpan.FromSeconds(30), UpdateResponse, sup);
      } else {
        TwitterStatusAsync.Update(Global.requestToken, strTweet, sup, TimeSpan.FromSeconds(30), UpdateResponse);
      }
    }

    void UpdateResponse(TwitterAsyncResponse<TwitterStatus> ee)
    {
      if (ee.ResponseObject == null) {
        TweetFailure(ee.Content);
        return;
      }

      InsertTweetIn(ee.ResponseObject, ColumnType.Timeline);
      if (ee.ResponseObject.Text.Contains("@" + Global.ThisUser.ScreenName)) {
        InsertTweetIn(ee.ResponseObject, ColumnType.Mentions);
      }

      this.Invoke(new Action(delegate
      {
        textTweet.Enabled = true;
        textTweet.Text = "";
        textTweet.Focus();

        buttonUpdate.Enabled = true;

        checkMedia.Enabled = true;
        checkMedia.Checked = false;
      }));
    }

    private void textTweet_TextChanged(object sender, EventArgs e)
    {
      int iCharactersLeft = 140 - GetTweetLength();

      if (iCharactersLeft < 0) {
        labelCharactersLeft.ForeColor = Color.OrangeRed;
        textTweet.BackColor = Color.DarkRed;
      } else if (iCharactersLeft < 20) {
        labelCharactersLeft.ForeColor = Color.Yellow;
        textTweet.BackColor = Color.FromArgb(139, 90, 0);
      } else {
        labelCharactersLeft.ForeColor = Color.White;
        textTweet.BackColor = Color.FromArgb(102, 102, 102);
      }

      labelCharactersLeft.Text = iCharactersLeft.ToString();

      if (textTweet.Text == "" || textTweet.Text == "What's happening?") {
        tw_idInReplyTo = 0;
      }
    }

    private void buttonLogout_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Are you sure you want to log out?", "TweetDeck Sucks", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
        Global.Settings.SetBool("started", false);
        Global.Settings.SetString("api_token", "");
        Global.Settings.SetString("api_token_secret", "");
        Global.Settings.Save();

        this.Close();
        Global.AuthForm.Show();
        Global.AuthForm.LoadStuff();
      }
    }

    private void textTweet_KeyDown(object sender, KeyEventArgs e)
    {
      // Ctrl+A, select all
      if (e.KeyCode == Keys.A && e.Modifiers == Keys.Control) {
        textTweet.SelectAll();
      }
    }

    private void FormDeck_Resize(object sender, EventArgs e)
    {
      // resize column heights accordingly
      for (int i = 0; i < flowColumns.Controls.Count; i++) {
        ColumnControl cc = (ColumnControl)flowColumns.Controls[i];
        cc.Height = flowColumns.Height - 3;
      }
    }

    private void FormDeck_ResizeEnd(object sender, EventArgs e)
    {
      Global.Settings.SetInt("deck_width", this.Width);
      Global.Settings.SetInt("deck_height", this.Height);
      Global.Settings.SetInt("deck_left", this.Left);
      Global.Settings.SetInt("deck_top", this.Top);
      Global.Settings.Save();
    }

    private void timerError_Tick(object sender, EventArgs e)
    {
      labelError.Visible = false;
    }

    private void checkMedia_CheckedChanged(object sender, EventArgs e)
    {
      groupMedia.Visible = checkMedia.Checked;
      if (!groupMedia.Visible) {
        tw_strMediaFilename = "";
        picMediaPreview.Image = null;
      }
      UpdateMediaGroupBoxes();
    }

    bool IsDragAllowed(DragEventArgs e)
    {
      bool bAllowed = false;
      if (
        new Rectangle(picMediaPreview.PointToScreen(Point.Empty), picMediaPreview.Size).Contains(Cursor.Position) ||
        new Rectangle(textTweet.PointToScreen(Point.Empty), textTweet.Size).Contains(Cursor.Position)
        ) {
        bAllowed = true;
      }

      if (bAllowed) {
        string[] astrAllowedExtensions = new string[] { "png", "jpg", "jpeg", "gif" };
        string[] astrFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
        if (astrFiles.Length == 1 && astrAllowedExtensions.Contains(astrFiles[0].Split('.').Last().ToLower())) {
          return true;
        }
      }

      return false;
    }

    private void FormDeck_DragOver(object sender, DragEventArgs e)
    {
      if (IsDragAllowed(e)) {
        e.Effect = DragDropEffects.Copy;
      } else {
        e.Effect = DragDropEffects.None;
      }
    }

    private void FormDeck_DragDrop(object sender, DragEventArgs e)
    {
      if (IsDragAllowed(e)) {
        checkMedia.Checked = true;
        tw_strMediaFilename = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
        picMediaPreview.LoadAsync(tw_strMediaFilename);
      }
    }

    private void buttonMediaBrowse_Click(object sender, EventArgs e)
    {
      OpenFileDialog dialog = new OpenFileDialog();
      dialog.Filter = "Image files (*.png;*.jpg;*.jpeg;*.gif)|*.png;*.jpg;*.jpeg;*.gif";
      if (dialog.ShowDialog() != DialogResult.OK) {
        return;
      }
      tw_strMediaFilename = dialog.FileName;
      picMediaPreview.LoadAsync(tw_strMediaFilename);
    }
  }
}
