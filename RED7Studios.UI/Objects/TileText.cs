/*
 * RED7 STUDIOS UI by Mitchell (RED7 STUDIOS)
 * GNU General Public License
 * LICENSE: https://github.com/RED7Studios/RED7Studios.UI/blob/master/LICENSE
 * 
 * Original File by NickAc.
*/

using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;

namespace RED7Studios.UI.Objects
{
	public class TileText
	{
		public TileText()
		{
		}
		public TileText(string text, Font font, Point location)
		{
			this.text = text;
			this.font = font;
			this.location = location;
		}
		Point location = Point.Empty;
		public virtual Point Location {
			get {
				return location;
			}
			set {
				location = value;
			}
		}
		
		String text = "TileText";
		public virtual String Text {
			get {
				return text;
			}
			set {
				text = value;
			}
		}
		
		Font font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
		public virtual Font Font {
			get {
				return font;
			}
			set {
				font = value;
			}
		}
		public override string ToString()
		{
			return "TileText";
		}
	}
}
