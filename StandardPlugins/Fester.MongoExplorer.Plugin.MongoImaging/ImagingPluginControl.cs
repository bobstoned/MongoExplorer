using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using Fester.MongoExplorer.Plugin;
using Fester.MongoExplorer.Common;
using IMAGE_EDIT = Blithe.Client.Controls.ImageEditor;
using IMAGING = Blithe.Common.Imaging;

namespace Fester.MongoExplorer.Plugin.MongoImaging {
	public partial class ImagingPluginControl : PluginControl {

		public ImagingPluginControl() {
			InitializeComponent();
			CreateEditor();
		}

		private void CreateEditor() {
			IMAGING.AnnotationList list = new IMAGING.AnnotationList();
			IMAGE_EDIT.ImageEditorFrame editor = new IMAGE_EDIT.ImageEditorFrame();
			Image image = Resources.Emmy;
			imageEditorFrame.ImageEditor.OriginalImage = image;
			// Create this or the drawing doesn't work !
			imageEditorFrame.ImageEditor.Changes = new IMAGING.AnnotationList();
			//editor.ImageEditor.OriginalImage = Image.FromFile(@"e:\img_9644.jpg");
			//imageEditorPanel.Controls.Add(editor);
			//editor.Dock = DockStyle.Fill;
			
		}

		private void getTemplatesButton_Click(object sender, EventArgs e) {
			// get the script templates names from the DB
			//List<string> templateNames = (this.Plugin as MongoImagingPlugin).GetTemplates();
			// load into the list box
			templateListBox.DataSource = (this.Plugin as MongoImagingPlugin).GetTemplates();
		}

		private void openFile_Click(object sender, EventArgs e) {
			if (fileDialog.ShowDialog() == DialogResult.OK) {
				imageEditorFrame.ImageEditor.OriginalImage = Image.FromFile(fileDialog.FileName);
			}
		}

		private void saveButton_Click(object sender, EventArgs e) {
			(this.Plugin as MongoImagingPlugin).Insert(
				nameTextBox.Text, descriptionTextBox.Text, regionTextBox.Text);
		}


	}
}
