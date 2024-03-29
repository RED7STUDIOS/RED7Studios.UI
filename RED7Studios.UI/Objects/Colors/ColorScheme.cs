﻿/*
 * RED7 STUDIOS UI by Mitchell (RED7 STUDIOS)
 * GNU General Public License
 * LICENSE: https://github.com/RED7Studios/RED7Studios.UI/blob/master/LICENSE
 * 
 * Original File by NickAc.
*/

using RED7Studios.UI.Utils;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using static RED7Studios.UI.Utils.GraphicUtils;

namespace RED7Studios.UI.Objects
{
    [TypeConverter(typeof(ColorSchemeConverter))]
    public class ColorScheme
    {
        #region Constructor
        public ColorScheme(Color primaryColor, Color secondaryColor)
        {
            PrimaryColor = primaryColor;
            SecondaryColor = secondaryColor;
            MouseDownColor = DarkenColor(primaryColor, 0.2f);
            MouseHoverColor = LightenColor(secondaryColor, 0.2F);
            if (primaryColor.IsDarker())
            {
                MouseDownColor = LightenColor(MouseDownColor, 0.2f);
                MouseHoverColor = LightenColor(MouseDownColor, 0.25f);
            }
        }
        #endregion

        #region Properties
        public Color PrimaryColor { get; set; }
        public Color SecondaryColor { get; set; }
        public Color MouseDownColor { get; set; }
        public Color MouseHoverColor { get; set; }
        public Color ForegroundColor => ForegroundColorForBackground(PrimaryColor);
        #endregion

        #region Static Methods
        public static Color DarkenColor(Color original, float value = 0.05f)
        {
            return ControlPaint.Dark(original, value);
        }

        public static Color LightenColor(Color original, float value = 0.05f)
        {
            return ControlPaint.Light(original, value);
        }
        
        public static ColorScheme CreateSimpleColorScheme(Color original)
        {
            return new ColorScheme(original, DarkenColor(original));
        }
        #endregion
    }
}
