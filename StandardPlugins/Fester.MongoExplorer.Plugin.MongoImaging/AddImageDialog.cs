using Blithe.Common.Media;
using Fester.MongoExplorer.Plugin.MongoImaging.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fester.MongoExplorer.Plugin.MongoImaging {
	public partial class AddImageDialog : Form {
		public AddImageDialog() {
			InitializeComponent();
		}

		public static ImageDoc OpenImage() {
			using (AddImageDialog dialog = new AddImageDialog()) {
				if (dialog.ShowDialog() == DialogResult.OK) {
					// update the name property from the text box
					dialog.document.Name = dialog.nameTextBox.Text;
					dialog.Close();
					return dialog.Document;
				}
				else {
					return null;
				}
			}
		}

		private Image selectedImage;

		public Image SelectedImage {
			get { return selectedImage; }
			set { selectedImage = value; }
		}

		private ImageDoc document;

		public ImageDoc Document {
			get {
				return document;
			}
		}

		private void CreateImageDocument(Image image, long imageSize) {
			document =  new ImageDoc() {
				Name = nameTextBox.Text,
				ImageData = ImageConversion.ImageToBase64(image, ImageFormat.Jpeg),
				Width = image.Width,
				Height = image.Height,
				Size = imageSize
			};
		}

		private void openFileButton_Click(object sender, EventArgs e) {
			if (chooseImageDialog.ShowDialog() == DialogResult.OK) {
				fileNameTextBox.Text = chooseImageDialog.FileName;
				System.IO.FileInfo file = new System.IO.FileInfo(chooseImageDialog.FileName);
				selectedImage = Image.FromFile(file.FullName);
				nameTextBox.Text = file.Name;
				CreateImageDocument(selectedImage, file.Length);
				dimensionsTextBox.Text = document.DimensionsDisplayText;
				sizeTextBox.Text = string.Format("{0} bytes", file.Length);
				UpdateState();
			}
		}

		private void UpdateState() {
			okButton.Enabled = !string.IsNullOrEmpty(nameTextBox.Text) && selectedImage != null;
		}

		private void okButton_Click(object sender, EventArgs e) {

		}

		private void nameTextBox_TextChanged(object sender, EventArgs e) {
			UpdateState();
		}
	}
}
