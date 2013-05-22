using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Twitterizer;
using Twitterizer.Streaming;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace TweetdeckSucks
{
  public enum ColumnType
  {
    Timeline,
    Mentions,
    DirectMessages,
    List,
  }

  public class Global
  {
    public static OAuthTokenResponse oauthToken;
    public static OAuthTokens requestToken;

    public static GlobalMessageFilter messageFilter = new GlobalMessageFilter();

    private static Dictionary<string, Image> _dicCachedImages = new Dictionary<string, Image>();
    public static void DownloadImageToPictureBox(PictureBox pic, string strURL, Control form)
    {
      // check if it's already cached
      if (_dicCachedImages.ContainsKey(strURL)) {
        pic.Image = _dicCachedImages[strURL];
        return;
      }

      // donwload the image
      WebClient wc = new WebClient();
      wc.Proxy = null;
      wc.DownloadDataCompleted += new DownloadDataCompletedEventHandler((object o, DownloadDataCompletedEventArgs e) => {
        //using (MemoryStream ms = new MemoryStream(e.Result)) {
        MemoryStream ms = new MemoryStream(e.Result);
          Image img = Image.FromStream(ms);
          _dicCachedImages[strURL] = img;
          form.Invoke(new Action(delegate
          {
            pic.Image = img;
          }));
        //}
      });
      wc.DownloadDataAsync(new Uri(strURL));
    }

    /// <summary>
    /// The authorization form
    /// </summary>
    public static Form1 AuthForm;

    /// <summary>
    /// The Deck form
    /// </summary>
    public static FormDeck DeckForm;

    /// <summary>
    /// Application settings
    /// </summary>
    public static Settings Settings = new Settings("Config.ini");

    /// <summary>
    /// Active Twitter user
    /// </summary>
    public static TwitterUser ThisUser;

    /// <summary>
    /// The active Twitter stream
    /// </summary>
    public static TwitterStream Streaming;
  }
}
