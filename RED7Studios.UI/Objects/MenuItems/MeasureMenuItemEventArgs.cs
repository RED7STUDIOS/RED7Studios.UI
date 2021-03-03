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
    public class MeasureMenuItemEventArgs : EventArgs
    {
        public MeasureMenuItemEventArgs(Font font, Graphics graphics, Size itemSize)
        {
            Font = font;
            Graphics = graphics;
            ItemSize = itemSize;
        }

        public Font Font { get; set; }
        public Graphics Graphics { get; set; }
        public Size ItemSize { get; set; } = Size.Empty;
    }
}
