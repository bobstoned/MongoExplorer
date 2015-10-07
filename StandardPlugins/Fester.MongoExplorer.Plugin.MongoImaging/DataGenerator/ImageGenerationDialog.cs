using Fester.Common;
using Fester.MongoExplorer.Plugin.MongoImaging.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fester.MongoExplorer.Plugin.MongoImaging {

	public partial class ImageGenerationDialog : Form {
		public ImageGenerationDialog() {
			InitializeComponent();
			CheckItemsInExtList();
		}

		private ImageDocActions actions;
		private List<string> badItems = new List<string>();
		private List<string> sampleFiles ;

		public ImageDocActions Actions {
			get { return actions; }
			set { actions = value; }
		}

		public List<string> BadItems {
			get { return badItems; }
		}

		/// <summary>
		/// Check all the items in the file extension listbox
		/// </summary>
		private void CheckItemsInExtList() {
			for (int i = 0; i < extListBox.Items.Count; i++) {
				extListBox.SetItemChecked(i, true);
			}
		}

		private List<string> GetSelectedExtensions() {
			List<string> extList = new List<string>();
			foreach (string ext in extListBox.CheckedItems) {
				extList.Add("." + ext);
				extList.Add("*." + ext);
			}
			return extList;
		}
		/*
		private List<string> GetPatients() {
			List<string> ext = new List<string>();
			if (!getAllCheckBox.Checked) {
				ext = GetSelectedExtensions();
			}
			return actions.GetPatientNumbers(GetScopeOptions(), ext, (int)patientCountUpDown.Value);
		}
		*/
		private ImageProcessingOptions GetScopeOptions() {
			if (scopeAllRadioButton.Checked)
				return ImageProcessingOptions.All;
			else if (scopeWithRadioButton.Checked)
				return ImageProcessingOptions.With;
			else if (scopeWithoutRadioButton.Checked)
				return ImageProcessingOptions.Without;
			else 
				return ImageProcessingOptions.None;
		}

		private void goButton_Click(object sender, EventArgs e) {
			ProcessPatients();
		}

		private List<string> GetSampleFiles() {
			FolderBrowserDialog ofd = new FolderBrowserDialog();
			if (string.IsNullOrEmpty(sampleFilesPathTextBox.Text)) {
				string defLocation = @"c:\temp";
				// Replace any reference of INSTALLDIR with the current directory, checking for both with and without a slash.
				defLocation = defLocation.Replace(@"%INSTALLDIR%\", AppDomain.CurrentDomain.BaseDirectory);
				defLocation = defLocation.Replace(@"%INSTALLDIR%", AppDomain.CurrentDomain.BaseDirectory);
				sampleFilesPathTextBox.Text = defLocation;
			}
			ofd.SelectedPath = sampleFilesPathTextBox.Text;
			if (ofd.ShowDialog() == DialogResult.OK) {
				sampleFilesPathTextBox.Text = ofd.SelectedPath;
				string[] files = Directory.GetFiles(ofd.SelectedPath);
				List<string> fileNames = new List<string>();
				fileNames.AddRange(files);
				//Add the file name of each item to the list box
				sampleFilesListBox.Items.Clear();
				foreach (string fileName in fileNames) {
					sampleFilesListBox.Items.Add(System.IO.Path.GetFileName(fileName), true);
				}
				UpdateSelectedFilesCount();
				return fileNames;
			}
			return null;
		}

		private List<string> GetSelectedFiles() {
			List<string> selectedFiles = new List<string>();
			foreach (int index in sampleFilesListBox.CheckedIndices) {
				selectedFiles.Add(sampleFiles[index]);
			}
			return selectedFiles;
		}

		private ImageDataGeneration imageProcessing;

		private void ProcessPatients() {
			goButton.Enabled = false;
			Application.DoEvents();
			if (imageProcessing != null) {
				// De-reference the current job
				imageProcessing.Progress -= imageProcessing_Progress;
				imageProcessing = null;
			}
			// Create a new image processing job
			imageProcessing = new ImageDataGeneration();
			imageProcessing.Actions = this.actions;
			imageProcessing.AddNewImages = addNewImagesCheckBox.Checked;
			imageProcessing.ReplaceEmptyImageData = replaceImagesCheckbox.Checked;
			imageProcessing.Progress += imageProcessing_Progress;
			if (sampleFiles == null) {
				sampleFiles = GetSampleFiles();
			}
			imageProcessing.ImageFileNames = GetSelectedFiles();
			if (imageProcessing.ImageFileNames != null) {
				imageProcessing.PatientNumbers = new List<string>() { "P000001", "P000002", "P000003", "P000004", "P000005" };  //GetPatients();
				ThreadedDataGeneration dataThread = new ThreadedDataGeneration(imageProcessing);
				Init();
				// run the job in a thread
				dataThread.Run();
			}
		}

		private void Init() {
			badItems.Clear();
			progressBar.Value = 0;
			progressBar.Maximum = imageProcessing.PatientNumbers.Count;
			failedTextBox.Text = "0";
			processedTextBox.Text = "0";
			closeButton.Enabled = false;
			cancelButton.Enabled = true;
			goButton.Enabled = false;
			Application.DoEvents();
		}

		void imageProcessing_Progress(object sender, ProgressEventArgs e) {
			switch (e.ProgressEvent) {
				case ProgressEvents.ProcessedItem:
					ReportProgress(e.ProgressEvent, e.ProgressPosition, (string)e.ProgressItem);
				break;
				case ProgressEvents.Completed: {
					ReportProgress(e.ProgressEvent, e.ProgressPosition, null);
				}
				break;
				case ProgressEvents.Cancelled: {
					imageProcessing.Cancel();
					ReportProgress(e.ProgressEvent, e.ProgressPosition, null);
				}
				break;
			}
		}

		delegate void ProgressCallback(ProgressEvents progressType, int progressValue, string patientNumber);

		/// <summary>
		/// Handles the reporting of the job state
		/// </summary>
		/// <param name="progressType"></param>
		/// <param name="progressValue"></param>
		/// <param name="image"></param>
		private void ReportProgress(ProgressEvents progressType, int progressValue, string patientNumber) {
			// Thread safe update of controls
			if (messageTextBox.InvokeRequired) {
				// re-call on the UI thread of this control
				Invoke(new ProgressCallback(ReportProgress), progressType, progressValue, patientNumber);
			}
			else {
				switch (progressType) {
					case ProgressEvents.ProcessedItem: {
							progressBar.Value = progressValue;
							processedTextBox.Text = progressValue.ToString();
						}
						break;
					case ProgressEvents.Cancelled: {
						MessageBox.Show(string.Format("The job was cancelled.\r\nSample images were added to {0} patients.", progressValue)
							, "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						EndJob();
					}
						break;
					case ProgressEvents.Completed: {
						if (badItems.Count > 0) {
							MessageBox.Show("Some images failed to save"
								, "Image Errors Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
						else {
							MessageBox.Show(string.Format("Sample images were added to {0} patients", progressValue), "Complete"
								, MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						EndJob();
					}
					break;
					case ProgressEvents.ErrorOccurred: {
						badItems.Add(patientNumber);
						messageTextBox.Text = string.Format("Error occurred, image batch was not saved, ({0})", patientNumber);
					}
						break;
				}
				Application.DoEvents();
			}			
		}

		private void EndJob() {
			closeButton.Enabled = true;
			cancelButton.Enabled = false;
			goButton.Enabled = true;
		}

		private void closeButton_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void cancelButton_Click(object sender, EventArgs e) {
			imageProcessing.Cancel();
		}

		private void textBox1_TextChanged(object sender, EventArgs e) {

		}

		private void browseButton_Click(object sender, EventArgs e) {
			sampleFiles = GetSampleFiles();
		}

		private void sampleFilesListBox_SelectedValueChanged(object sender, EventArgs e) {
			UpdateSelectedFilesCount();
		}

		private void UpdateSelectedFilesCount() {
			int checkedCount = sampleFilesListBox.CheckedItems.Count;
			goButton.Enabled = checkedCount > 0 && (addNewImagesCheckBox.Checked || replaceImagesCheckbox.Checked);
			if (checkedCount == 0) {
				filesCountLabel.Text = "No files selected";
			}
			else {
				filesCountLabel.Text = string.Format("{0} of {1} files selected", checkedCount, sampleFilesListBox.Items.Count);
			}
		}

		private void ImageGenerationDialog_FormClosing(object sender, FormClosingEventArgs e) {
			if (imageProcessing != null && imageProcessing.IsProcessing) {
				e.Cancel = true;
			}
		}

		private void updateOptionsClick(object sender, EventArgs e) {
			UpdateSelectedFilesCount();
		}

		private void getAllCheckBox_CheckedChanged(object sender, EventArgs e) {
			extListBox.Enabled = !getAllCheckBox.Checked;
		}
	}

}
