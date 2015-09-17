using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fester.MongoExplorer.App {

	public class ApplicationTheme {

		private string themeName;
		private Color baseColor;
		private Color buttonBorder;
		private Color inputBorder;
		private Color inputFill;
		private Color tabFill;
		private Color buttonFill;

		public string ThemeName {
			get { return themeName; }
			set { themeName = value; }
		}

		public Color BaseColor {
			get { return baseColor; }
			set { baseColor = value; }
		}

		public Color TabFill {
			get { return tabFill; }
			set { tabFill = value; }
		}

		public Color PanelFill {
			get { return tabFill; }
			set { tabFill = value; }
		}

		public Color ButtonFill {
			get { return buttonFill; }
			set { buttonFill = value; }
		}

		public Color ButtonBorder {
			get { return buttonBorder; }
			set { buttonBorder = value; }
		}

		public Color InputBorder {
			get { return inputBorder; }
			set { inputBorder = value; }
		}

		public Color InputFill {
			get { return inputFill; }
			set { inputFill = value; }
		}

		public ApplicationTheme() {

		}

		public ApplicationTheme(string name, Color baseColor, Color tabFill, Color buttonFill, Color buttonBorder, Color inputFill) {
		}

	}
}
