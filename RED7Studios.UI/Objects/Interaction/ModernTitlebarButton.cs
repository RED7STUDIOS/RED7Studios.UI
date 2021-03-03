/*
 * RED7 STUDIOS UI by Mitchell (RED7 STUDIOS)
 * GNU General Public License
 * LICENSE: https://github.com/RED7Studios/RED7Studios.UI/blob/master/LICENSE
 * 
 * Original File by NickAc.
*/

using RED7Studios.UI.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RED7Studios.UI.Objects.Interaction
{
    public class ModernTitlebarButton
    {
        #region Events
        /// <summary>
        /// Called to signal to subscribers that this button was clicked
        /// </summary>
        public event EventHandler<MouseEventArgs> Click;
        public void OnClick(MouseEventArgs e)
        {
            var eh = Click;
            eh?.Invoke(this, e);
        }
        #endregion

        #region Properties
        public virtual Font Font { get; set; } = SystemFonts.CaptionFont;
        public virtual String Text { get; set; }
        public virtual int Width { get; set; } = ModernForm.DefaultTitlebarHeight;
        public virtual Boolean Visible { get; set; } = true;

        #endregion

    }
}
