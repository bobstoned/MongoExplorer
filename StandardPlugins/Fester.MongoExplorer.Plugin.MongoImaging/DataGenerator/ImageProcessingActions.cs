using Blithe.Common.Media;
using Fester.MongoExplorer.Plugin.MongoImaging.Collections;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fester.MongoExplorer.Plugin.MongoImaging {

	/// <summary>
	/// Various functions for processing images in the imaging module
	/// </summary>
	public class ImageProcessingActions {
		
		/// <summary>
		/// Creates a new batch of images from the images specified in the file list
		/// </summary>
		/// <param name="patientNumber">Patient unique identifier</param>
		/// <param name="sourceTable">The entity to which the batch will belong (e.g. "lvEpisode")</param>
		/// <param name="fileNames">A list of file names of images to add to the batch</param>
		/// <returns>a new image batch contaiing the specified images</returns>
		public static List<ImageDoc> CreateNewBatchOfTestImages(string patientNumber, string sourceTable, List<string> fileNames) {
			// Create a new image batch 
			List<ImageDoc> imageBatch = new List<ImageDoc>();
			// add images from the file list into the batch
			foreach(string fileName in fileNames) {
				// get the byte data for the file
				//byte[] data = GetTestImage(fileName);
				Image selectedImage = Image.FromFile(fileName);
				FileInfo info = new FileInfo(fileName);
				// create a new image document
				ImageDoc newImage = new ImageDoc();
				newImage.Annotations = new List<ImageDoc.Annotation>();
				newImage.ImageData = ImageConversion.ImageToBase64(selectedImage, ImageFormat.Jpeg);
				newImage.Name = info.Name;
				newImage.Width = selectedImage.Width;
				newImage.Height = selectedImage.Height;
				newImage.Size = info.Length;
				// add the new image document to the batch
				imageBatch.Add(newImage);
			}
			// the new image batch
			return imageBatch;
		}

		private static byte[] GetSampleFileForExtension(string ext) {
			string fileName = testImages.Keys.FirstOrDefault(f=>f.Contains(ext));
			if (!string.IsNullOrEmpty(fileName)) {
				return testImages[fileName];
			}
			else {
				return null;
			}
		}

		private static Dictionary<string, byte[]> testImages = new Dictionary<string,byte[]>();

		private static Dictionary<string, byte[]> TestImages {
			get { 
				return ImageProcessingActions.testImages; 
			}
		}

		/// <summary>
		/// Gets the byte data of the specified file
		/// Also adds it into the cache
		/// </summary>
		/// <param name="fileName">Filename of the image to retrieve</param>
		/// <returns>byte array of the image contents</returns>
		public static byte[] GetTestImage(string fileName) {
			List<byte[]> filesData = new List<byte[]>();
			if (!testImages.ContainsKey(fileName)) {
				// cache the image data for the file
				testImages.Add(fileName, GetTestFile(fileName));
			}
			return testImages[fileName];
		}

		/// <summary>
		/// get the raw byte data from the specified file
		/// </summary>
		/// <param name="fileName">file to read</param>
		/// <returns>byte data of file contents</returns>
		public static byte[] GetTestFile(string fileName) {
			using (FileStream fs = File.Open(fileName, FileMode.Open)) {
				byte[] data = new byte[fs.Length];
				fs.Read(data, 0, (int)fs.Length);
				fs.Close();
				return data;
			}
		}
		
	}

}
