using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Twitterizer;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Twitterizer.Streaming;
using System.Web;

namespace TweetdeckSucks
{
  public partial class ColumnControl : UserControl
  {
    public ColumnType ColType = ColumnType.Timeline;
    public string ListLocation = "";

    public ColumnControl()
    {
      InitializeComponent();
    }

    public void SetColumnType(string type, string meta)
    {
      object o = Enum.Parse(typeof(ColumnType), type);
      System.Diagnostics.Debug.Assert(o != null);
      if (o == null) {
        return;
      }
      SetColumnType((ColumnType)o, meta);
    }

    public void SetColumnType(ColumnType type, string meta)
    {
      ColType = type;
      switch (type) {
        case ColumnType.Timeline: labelColumnName.Text = "All Friends"; break;
        case ColumnType.Mentions: labelColumnName.Text = "Mentions"; break;
        case ColumnType.DirectMessages: labelColumnName.Text = "Direct Messages"; break;
        case ColumnType.List: ListLocation = meta; labelColumnName.Text = "@" + meta; break;
      }
    }

    public void DownloadInitialTweets()
    {
      switch (ColType) {
        case ColumnType.Timeline: TwitterTimelineAsync.HomeTimeline(Global.requestToken, null, TimeSpan.FromSeconds(30), ProcessTweetsCallback); break;
        case ColumnType.Mentions: TwitterTimelineAsync.Mentions(Global.requestToken, null, TimeSpan.FromSeconds(30), ProcessTweetsCallback); break;
        case ColumnType.DirectMessages: TwitterDirectMessageAsync.DirectMessages(Global.requestToken, null, TimeSpan.FromSeconds(30), ProcessDMCallback); break; // TODO: Get sent DM's too
        case ColumnType.List:
          string[] astrListParse = ListLocation.Split('/');
          TwitterListAsync.GetStatuses(Global.requestToken, astrListParse[0], astrListParse[1], null, TimeSpan.FromSeconds(30), ProcessTweetsCallback);
          break;
      }
    }

    public void ProcessTweetsCallback(TwitterAsyncResponse<TwitterStatusCollection> ee)
    {
      TwitterStatusCollection tweets = ee.ResponseObject;
      if (tweets == null) {
        Global.DeckForm.TweetFailure(ee.Content);
        return;
      }
      for (int i = tweets.Count - 1; i >= 0; i--) {
        InsertTweet(flowColumn, tweets[i]);
      }
    }

    public void ProcessDMCallback(TwitterAsyncResponse<TwitterDirectMessageCollection> ee)
    {
      TwitterDirectMessageCollection dms = ee.ResponseObject;
      if (dms == null) {
        return;
      }
      for (int i = dms.Count - 1; i >= 0; i--) {
        InsertDM(flowColumn, dms[i]);
      }
    }

    public string FormatDate(DateTime date)
    {
      // Tue 07 May 13:34
      return date.ToString("ddd dd MMM HH:mm");
    }

    public void FindAlternativeLinks(RichTextBoxEx rt)
    {
      int iSelStart = -1;

      string strAllowedCharactersInUsername = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_";
      for (int i = 0; i < rt.Text.Length; i++) {
        if (rt.Text[i] == '@' || rt.Text[i] == '#') {
          iSelStart = i;
        } else {
          if (iSelStart >= 0 && (!strAllowedCharactersInUsername.Contains(rt.Text[i]) || i == rt.Text.Length - 1)) {
            rt.Select(iSelStart, i - iSelStart + (i == rt.Text.Length - 1 ? 1 : 0));
            rt.SetSelectionLink(true); // this function only exists because of RichTextBoxEx!
            rt.Select(0, 0);
            iSelStart = -1;
          }
        }
      }
    }

    public void InsertTweet(FlowLayoutPanel panel, TwitterStatus tweet)
    {
      this.Invoke(new Action(delegate
      {
        // parse tweet source
        string strViaURL = "https://" + "twitter.com/";
        string strViaName = tweet.Source;
        if (strViaName != "web") {
          Match match = Regex.Match(strViaName, @"<a href=""(.*)"" .*>(.*)</a>");
          if (match.Success) {
            strViaURL = match.Groups[1].Value;
            strViaName = match.Groups[2].Value;
          }
        }

        // insert new tweet in list
        TweetControl tc = new TweetControl();
        Global.DownloadImageToPictureBox(tc.picAvatar, tweet.User.ProfileImageSecureLocation, this);
        tc.labelFollowers.Text = tweet.User.NumberOfFollowers.Value.ToString();
        tc.labelName.Text = tweet.User.ScreenName;
        tc.labelDate.Text = FormatDate(tweet.CreatedDate);
        tc.labelVia.Text = "via " + strViaName;
        if (tweet.InReplyToStatusId.HasValue) {
          tc.labelInReplyTo.Text = "in reply to " + tweet.InReplyToScreenName;
        } else {
          tc.labelInReplyTo.Text = "";
        }
        //tc.labelText.Text = tweet.Text;
        tc.rtText.Text = HttpUtility.HtmlDecode(tweet.Text);
        FindAlternativeLinks(tc.rtText);
        tc.Width = panel.Width - 8 - panel.Padding.Right;
        tc.Tweet = tweet;
        tc.ViaURL = strViaURL;
        tc.ViaName = strViaName;
        panel.Controls.Add(tc);
        panel.Controls.SetChildIndex(tc, 0);

        // limit amount of tweets in list
        if (panel.Controls.Count > 100) {
          // delete anything after 100
          for (int i = 101; i < panel.Controls.Count; i++) {
            panel.Controls.RemoveAt(101); // index should always be 101... o___o
            // ...this loop looks weird.
          }
        }
      }));
    }

    public void InsertDM(FlowLayoutPanel panel, TwitterDirectMessage dm)
    {
      this.Invoke(new Action(delegate
      {
        // insert new DM in list
        TweetControl tc = new TweetControl();
        Global.DownloadImageToPictureBox(tc.picAvatar, dm.Sender.ProfileImageSecureLocation, this);
        tc.labelFollowers.Text = dm.Sender.NumberOfFollowers.Value.ToString();
        tc.labelName.Text = dm.Sender.ScreenName;
        tc.labelDate.Text = FormatDate(dm.CreatedDate);
        tc.labelVia.Text = "via Direct Message";
        tc.labelInReplyTo.Text = "";
        //tc.labelText.Text = dm.Text;
        tc.rtText.Text = dm.Text;
        FindAlternativeLinks(tc.rtText);
        tc.Width = panel.Width - 8 - panel.Padding.Right;
        tc.DM = dm;
        panel.Controls.Add(tc);
        panel.Controls.SetChildIndex(tc, 0);

        // limit amount of tweets in list
        if (panel.Controls.Count > 100) {
          // delete anything after 100
          for (int i = 101; i < panel.Controls.Count; i++) {
            panel.Controls.RemoveAt(101); // index should always be 101... o___o
            // this loop looks weird.
          }
        }
      }));
    }
  }
}
