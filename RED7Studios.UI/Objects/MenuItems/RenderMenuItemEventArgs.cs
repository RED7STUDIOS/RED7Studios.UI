/*
 * RED7 STUDIOS UI by Mitchell (RED7 STUDIOS)
 * GNU General Public License
 * LICENSE: https://github.com/RED7Studios/RED7Studios.UI/blob/master/LICENSE
 * 
 * Original File by NickAc.
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace RED7Studios.UI.Objects.MenuItems
{
    public class RenderMenuItemEventArgs : EventArgs
    {
        public RenderMenuItemEventArgs(Graphics graphics, Rectangle rectangle, Font font)
        {
            Graphics = graphics;
            Rectangle = rectangle;
            Font = font;
        }

        public Font Font { get; set; }
        public Graphics Graphics { get; set; }
        public Rectangle Rectangle { get; set; }
    }
}
