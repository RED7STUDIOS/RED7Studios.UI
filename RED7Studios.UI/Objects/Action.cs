﻿/*
 * RED7 STUDIOS UI by Mitchell (RED7 STUDIOS)
 * GNU General Public License
 * LICENSE: https://github.com/RED7Studios/RED7Studios.UI/blob/master/LICENSE
 * 
 * Original File by NickAc.
*/

using RED7Studios.UI.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RED7Studios.UI.Objects
{
    [Serializable]
    public class AppAction
    {        

        public Image Image { get; set; }
        public Cursor Cursor { get; set; }
        public string ToolTip { get; set; }
        
        
        

        /// <summary>
        /// Called to signal to subscribers that it was clicked.
        /// </summary>
        public event EventHandler Click;
        public virtual void OnClick(EventArgs e)
        {
            EventHandler eh = Click;

            eh?.Invoke(this, e);
        }


        public Rectangle GetRectangle(AppBar bar, List<AppAction> containerList)
        {
            if (bar != null && containerList != null && containerList.Contains(this))
            {
                int index = containerList.IndexOf(this) + (bar.MenuItems != null && bar.MenuItems.Count > 0 ? 1 : 0);
                int xTextOffset = bar.XTextOffset;
                int size = bar.Height - xTextOffset;
                int xTextOffsetHalf = bar.XTextOffset / 2;
                int right = bar.Width - xTextOffsetHalf - (index * size + xTextOffsetHalf * index);
                return Rectangle.FromLTRB(right - size, xTextOffsetHalf, right, bar.Height - xTextOffsetHalf);
            }
            return Rectangle.Empty;
        }
    }
}
