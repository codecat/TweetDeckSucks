using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Twitterizer;
using System.Diagnostics;

namespace TweetdeckSucks
{
  public partial class TweetControl : UserControl
  {
    public TwitterStatus Tweet;
    public TwitterDirectMessage DM;

    public string ViaURL = "https://" + "twitter.com/";
    public string ViaName = "web";

    public bool Deleted = false;

    public TweetControl()
    {
      InitializeComponent();
    }

    public void ShowButtons(bool bVisible)
    {
      if (buttonReply.Visible != bVisible) {
        buttonReply.Visible = bVisible;
        buttonRetweet.Visible = bVisible;
        buttonDM.Visible = bVisible;
        buttonOptions.Visible = bVisible;

        Invalidate();
      }
    }

    public void MarkDeleted()
    {
      // TODO: Add an option here whether to remove from list or to simply mark as "deleted".
      this.Invoke(new Action(delegate
      {
        /*Deleted = true;
        foreach (Control c in Controls) {
          int r = c.ForeColor.R / 2;
          int g = c.ForeColor.G / 2;
          int b = c.ForeColor.B / 2;
          c.ForeColor = Color.FromArgb(r, g, b);
        }*/
        Parent.Controls.Remove(this);
      }));
    }

    public string GetTweetURL()
    {
      return "https://" + "twitter.com/" + Tweet.User.ScreenName + "/statuses/" + Tweet.Id;
    }

    private void labelName_Click(object sender, EventArgs e)
    {
      Global.DeckForm.ShowInlineUserInfo(Tweet.User.ScreenName);
    }

    private void labelDate_Click(object sender, EventArgs e)
    {
      if (DM != null) {
        return;
      }
      Process.Start(GetTweetURL());
    }

    private void labelVia_Click(object sender, EventArgs e)
    {
      if (DM != null) {
        return;
      }
      Process.Start(ViaURL);
    }

    private void labelInReplyTo_Click(object sender, EventArgs e)
    {
      Global.DeckForm.ShowInlineConversation(Tweet.InReplyToStatusId.GetValueOrDefault());
    }

    private void openURLToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (DM != null) {
        return;
      }
      Process.Start(GetTweetURL());
    }

    private void copyLinkToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (DM != null) {
        return;
      }
      Clipboard.SetText(GetTweetURL());
    }

    private void toolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (DM != null) {
        return;
      }
      Process.Start(ViaURL);
    }

    private void toolStripMenuItem2_Click(object sender, EventArgs e)
    {
      if (DM != null) {
        return;
      }
      Clipboard.SetText(ViaURL);
    }

    private void rtText_LinkClicked(object sender, LinkClickedEventArgs e)
    {
      string strLink = e.LinkText;

      if (strLink[0] == '@') {
        Global.DeckForm.ShowInlineUserInfo(strLink);
      } else if(strLink[0] == '#') {
        Global.DeckForm.ShowHashtagInfo(strLink);
      } else {
        Process.Start(strLink);
      }
    }

    private void buttonReply_Click(object sender, EventArgs e)
    {
      Global.DeckForm.textTweet.Focus();

      if (Global.DeckForm.textTweet.Text == "") {
        if (Tweet != null) {
          Global.DeckForm.tw_idInReplyTo = Tweet.Id;
        } else if (DM != null) {
          Global.DeckForm.textTweet.Text = "D " + Tweet.User.ScreenName + " ";
          Global.DeckForm.textTweet.SelectionStart = Global.DeckForm.textTweet.Text.Length;
        }
      }

      if (Tweet != null) {
        int iSel = Global.DeckForm.textTweet.SelectionStart;
        string strAdd = "@" + Tweet.User.ScreenName + " ";
        Global.DeckForm.textTweet.Text += strAdd;
        Global.DeckForm.textTweet.SelectionStart = iSel + strAdd.Length;
      }
    }

    private void buttonRetweet_Click(object sender, EventArgs e)
    {
      if (ModifierKeys == Keys.Shift) {
        Tweet.Retweet(Global.requestToken);
      } else {
        Global.DeckForm.textTweet.Focus();
        Global.DeckForm.textTweet.Text = "RT @" + Tweet.User.ScreenName + ": " + rtText.Text;
        Global.DeckForm.textTweet.SelectionStart = Global.DeckForm.textTweet.Text.Length;
      }
    }

    private void buttonDM_Click(object sender, EventArgs e)
    {
      Global.DeckForm.textTweet.Focus();
      Global.DeckForm.textTweet.Text = "D " + Tweet.User.ScreenName + " ";
      Global.DeckForm.textTweet.SelectionStart = Global.DeckForm.textTweet.Text.Length;
    }

    private void buttonOptions_Click(object sender, EventArgs e)
    {

    }
  }
}
