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
using Fester.MongoExplorer.Plugin.MongoImaging.Collections;
using Blithe.Common.Media;

namespace Fester.MongoExplorer.Plugin.MongoImaging {
	public partial class ImagingPluginControl : PluginControl {

		public ImagingPluginControl() {
			InitializeComponent();
		}

		private async void getImagesButton_Click(object sender, EventArgs e) {
			ImageDoc.ImageFilter filter = new ImageDoc.ImageFilter() {
				Name = nameFilterTextBox.Text,
				Height = (int)heightUpDown.Value,
				Width = (int)widthUpDown.Value,
				Size = (int)sizeUpDown.Value,
			};
			imageBrowserControl.Images = await (this.Plugin as MongoImagingPlugin).GetImagesAsync(filter);
		}

		private void saveButton_Click(object sender, EventArgs e) {
			imageBrowserControl.CommitChanges();
			// Save each image document
			foreach (ImageDoc doc in imageBrowserControl.Images) {
				(this.Plugin as MongoImagingPlugin).Save(doc);
			}
		}

		private void addImageButton_Click(object sender, EventArgs e) {
			ImageDoc imageDoc = AddImageDialog.OpenImage();
			imageBrowserControl.AddImage(imageDoc);
		}

		private void generateButton_Click(object sender, EventArgs e) {
			using (ImageGenerationDialog dialog = new ImageGenerationDialog()) {
				dialog.Actions = new ImageDocActions(this.Plugin.Explorer);
				dialog.ShowDialog(this);
				dialog.Close();
			}
		}


	}
}
