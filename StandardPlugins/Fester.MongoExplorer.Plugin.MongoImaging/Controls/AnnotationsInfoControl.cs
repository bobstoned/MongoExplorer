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
using IMAGES = Blithe.Common.Imaging;

namespace Fester.MongoExplorer.Plugin.MongoImaging {
	public partial class AnnotationsInfoControl : UserControl {
		public AnnotationsInfoControl() {
			InitializeComponent();
			imageEditorFrame.ImageEditor.OriginalImage = Resources.AnnotationBackground;
			imageEditorFrame.ImageEditor.Changes = new IMAGES.AnnotationList();
		}

		private List<ImageDoc.Annotation> annotations;

		public List<ImageDoc.Annotation> Annotations {
			get { return annotations; }
			set { 
				annotations = value;
				if (annotations != null) {
					imageBindingSource.DataSource = annotations;
				}
			}
		}

		private void imageBindingSource_CurrentChanged(object sender, EventArgs e) {

		}

		private void imageBindingSource_CurrentItemChanged(object sender, EventArgs e) {
			if (imageBindingSource.Current != null) {
				pointBindingSource.DataSource = (imageBindingSource.Current as ImageDoc.Annotation).Points;
				fillColorControl.ColorValue = (imageBindingSource.Current as ImageDoc.Annotation).FillColor;
				lineColorControl.ColorValue = (imageBindingSource.Current as ImageDoc.Annotation).LineColor;
				rectControl.BoundingRect = (imageBindingSource.Current as ImageDoc.Annotation).Rect;
				imageEditorFrame.ImageEditor.Changes.Clear();
				CreateImageAnnotation((imageBindingSource.Current as ImageDoc.Annotation));
				// force the preview to redraw
				imageEditorFrame.ImageEditor.RefreshAll();
			}
		}

		private void CreateImageAnnotation(ImageDoc.Annotation annotation) {
			// Create this or the drawing doesn't work !
			IMAGES.BaseAnnotation baseAnnotation =
				TranslateAnnotation.Translate(
						annotation,
						1.0f,
						new IMAGES.ColourFormat(IMAGES.ColourFormat.COLOUR_FORMAT_32_BIT_COLOR),
						new PointF(0, 0),
						new PointF(0, 0)
				);
			baseAnnotation.Rect = new RectangleF(0, 0, baseAnnotation.Rect.Width, baseAnnotation.Rect.Height);
			baseAnnotation.UpdateScreenRect();
			imageEditorFrame.ImageEditor.Changes.Add(baseAnnotation);
		}

		private void addButton_Click(object sender, EventArgs e) {
			CreateImageAnnotation(annotations[0]);
		}


	}
}
