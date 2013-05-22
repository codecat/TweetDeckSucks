using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace TweetdeckSucks
{
  public class GlobalMessageFilter : IMessageFilter
  {
    // HACK: This is how we show/hide the buttons over avatars in tweets.
    public bool PreFilterMessage(ref Message m)
    {
      if (m.Msg == 0x0200 /* WM_MOUSEMOVE */ && Global.DeckForm != null) {
        foreach (ColumnControl cc in Global.DeckForm.flowColumns.Controls) {
          foreach (TweetControl tc in cc.flowColumn.Controls) {
            Rectangle rectAvatar = new Rectangle(tc.picAvatar.PointToScreen(Point.Empty), tc.picAvatar.Size);
            tc.ShowButtons(rectAvatar.Contains(Cursor.Position));
          }
        }
      }
      return false;
    }
  }
}
