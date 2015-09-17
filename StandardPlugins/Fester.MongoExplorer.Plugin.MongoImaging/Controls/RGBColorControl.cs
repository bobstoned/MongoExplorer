using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fester.MongoExplorer.Plugin.MongoImaging.Collections;
using Fester.MongoExplorer.Common;

namespace Fester.MongoExplorer.Plugin.MongoImaging.Controls {
	public partial class RGBColorControl : UserControl {
		public RGBColorControl() {
			InitializeComponent();
		}

		ImageDoc.ColorType colorValue;

		public ImageDoc.ColorType ColorValue {
			get { return colorValue; }
			set { 
				colorValue = value;
				if (colorValue != null) {
					colorBindingSource.DataSource = colorValue;
				}
			}
		}

		private void colorBindingSource_CurrentItemChanged(object sender, EventArgs e) {

		}

		private void colorPanel_Paint(object sender, PaintEventArgs e) {

		}

		private void colorPanel_DoubleClick(object sender, EventArgs e) {
			colorDialog.Color = Color.FromArgb(colorValue.R, colorValue.G, colorValue.B);
			if (colorDialog.ShowDialog() == DialogResult.OK) {
				colorValue.R = colorDialog.Color.R;
				colorValue.G = colorDialog.Color.G;
				colorValue.B = colorDialog.Color.B;
				colorBindingSource.ResetCurrentItem();
				UpdateColorPanel();
			}
		}

		private void UpdateColorPanel() {
			colorPanel.BackColor = Color.FromArgb(colorValue.R, colorValue.G, colorValue.B);
		}

		private void colorBindingSource_ListChanged(object sender, ListChangedEventArgs e) {
			if (ColorValue != null) {
				UpdateColorPanel();
			}
		}

	}
}
