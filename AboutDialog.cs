using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fester.MongoExplorer.App {
	public partial class AboutDialog : Form {
		public AboutDialog() {
			InitializeComponent();
			Tools.ApplyStyle(this, Color.DarkGray, Color.Gray, Color.LightSalmon, Color.DarkRed, Color.White);
		}

		public static void ShowAboutDialog() {
			using (AboutDialog dialog = new AboutDialog()) {
				dialog.ShowDialog();
				dialog.Close();
			}
		}

		private void closeButton_Click(object sender, EventArgs e) {
			this.Close();
		}
	}
}
