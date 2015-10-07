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
using Blithe.Common.Imaging;
using Blithe.Common.Media;

namespace Fester.MongoExplorer.Plugin.MongoImaging.Controls {
	public partial class ImageBrowserControl : UserControl {
		public ImageBrowserControl() {
			InitializeComponent();
		}

		public ImageDoc Current {
			get { 
				return imageBindingSource.Current as ImageDoc; 
			}
		}

		private List<ImageDoc> images;

		public List<ImageDoc> Images {
			get { return images; }
			set { 
				images = value;
				if (images != null) {
					imageEditorFrame.ImageEditor.Changes = new AnnotationList();
					imageBindingSource.DataSource = images;
					UpdateState();
				}
			}
		}

		public void AddImage(ImageDoc image) {
			imageBindingSource.Add(image);
		}

		private void imageBindingSource_PositionChanged(object sender, EventArgs e) {
			UpdateState();
		}


		ImageDoc lastDoc = null;

		private void UpdateState() {
			if (this.Current != null) {
				GetAnnotationsFromEditor(lastDoc);
				string data = this.Current.ImageData;
				if (!string.IsNullOrEmpty(data)) {
					imageEditorFrame.ImageEditor.OriginalImage =
						ImageConversion.Base64ToImage(data);
				}
				GetEditorAnnotationFromDoc(this.Current);
				lastDoc = this.Current;
			}
		}

		/// <summary>
		/// Copy the last edits into the current annotation
		/// </summary>
		public void CommitChanges() {
			GetAnnotationsFromEditor(this.Current);
		}

		private void ShowAnnotationInfo() {
			//annotationsInfoControl.Annotations = (imageBindingSource.Current as ImageDoc).Annotations;
		}

		private void GetAnnotationsFromEditor(ImageDoc doc) {
			if (doc != null) {
				doc.Annotations = TranslateAnnotation.Translate(imageEditorFrame.ImageEditor.Changes);
			}
		}

		private void GetEditorAnnotationFromDoc(ImageDoc doc) {
			if (doc != null) {
				imageEditorFrame.ImageEditor.Changes = 
					TranslateAnnotation.Translate(doc.Annotations, 1.0f, new ColourFormat(ColourFormat.COLOUR_FORMAT_32_BIT_COLOR)
						, new PointF(0,0), new PointF(0,0));
			}
		}

	}
}
