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

namespace Fester.MongoExplorer.Plugin.MongoImaging.Controls {
	public partial class RectControl : UserControl {

		public RectControl() {
			InitializeComponent();
		}

		private ImageDoc.BoundingRect boundingRect;

		public ImageDoc.BoundingRect BoundingRect {
			get { return boundingRect; }
			set {
				boundingRect = value;
				if (boundingRect != null) {
					rectBindingSource.DataSource = boundingRect;
					pointBindingSource.DataSource = boundingRect.TopLeft;
				}
			}
		}
	
	}
}
