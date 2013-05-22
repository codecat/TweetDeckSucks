using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Twitterizer;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace TweetdeckSucks
{
  public partial class Form1 : Form
  {
    bool frm_bShouldHide = false;

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    static extern bool SetForegroundWindow(IntPtr hWnd);

    string strConsumerKey = "dqht7sXPTrCJvvvwSkDRDw";
    string strConsumerSecret = "VtUoXj2AXfdAhJPZP1K9Bo7RLjB5jBr2XfZD3zliMvs";

    public Form1()
    {
      InitializeComponent();

      Global.AuthForm = this;

      LoadStuff();
    }

    public void LoadStuff()
    {
      string strToken = Global.Settings.GetString("api_token");
      string strTokenSecret = Global.Settings.GetString("api_token_secret");

      Global.DeckForm = new FormDeck();

      if (strToken != "" && strTokenSecret != "") {
        Global.requestToken = new OAuthTokens() {
          AccessToken = strToken,
          AccessTokenSecret = strTokenSecret,
          ConsumerKey = strConsumerKey,
          ConsumerSecret = strConsumerSecret
        };

        // get authenticated user's profile
        TwitterAccountAsync.VerifyCredentials(Global.requestToken, TimeSpan.FromSeconds(30), (TwitterAsyncResponse<TwitterUser> e) => {
          Global.ThisUser = e.ResponseObject;

          // load the deck form
          this.Invoke(new Action(delegate
          {
            Global.DeckForm.Show();
            SetForegroundWindow(Global.DeckForm.Handle);
          }));
        });

        frm_bShouldHide = true;
        return;
      }

      button1.Enabled = false;
      textPinCode.Enabled = false;

      OAuthUtilityAsync.GetRequestToken(strConsumerKey, strConsumerSecret, "oob", null, TimeSpan.FromSeconds(30), (OAuthTokenResponse e) => {
        Global.oauthToken = e;
        webBrowser1.Navigate("https://" + "twitter.com/oauth/authorize?oauth_token=" + e.Token);

        this.Invoke(new Action(delegate
        {
          button1.Enabled = true;
          textPinCode.Enabled = true;
        }));
      });
    }

    private void button1_Click(object sender, EventArgs e)
    {
      button1.Enabled = false;
      textPinCode.Enabled = false;

      OAuthUtilityAsync.GetAccessToken(strConsumerKey, strConsumerSecret, Global.oauthToken.Token, textPinCode.Text, null, TimeSpan.FromSeconds(30), (OAuthTokenResponse ee) => {
        Global.requestToken = new OAuthTokens() {
          AccessToken = ee.Token,
          ConsumerSecret = ee.TokenSecret,
          ConsumerKey = strConsumerKey,
          AccessTokenSecret = strConsumerSecret
        };

        Global.Settings.SetString("api_token", ee.Token);
        Global.Settings.SetString("api_token_secret", ee.TokenSecret);
        Global.Settings.Save();

        this.Invoke(new Action(delegate
        {
          Global.DeckForm.Show();
          this.Hide();
        }));
      });
    }

    private void Form1_Activated(object sender, EventArgs e)
    {
      if (frm_bShouldHide) {
        frm_bShouldHide = false;
        this.Hide();
      }
    }
  }
}
