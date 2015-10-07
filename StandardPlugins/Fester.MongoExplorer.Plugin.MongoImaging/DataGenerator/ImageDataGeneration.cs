using Fester.Common;
using Fester.MongoExplorer.Plugin.MongoImaging.Collections;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fester.MongoExplorer.Plugin.MongoImaging {

	/// <summary>
	/// Image data processing class, can be used within a thread
	/// </summary>
	public class ImageDataGeneration : IDataGeneration {

		public event ProgressEventHandler Progress;
		private bool cancelled = false;
		private bool isProcessing = false;
		private int errorCount = 0;
		List<string> patientNumbers;
		List<string> imageFileNames;
		private ImageDocActions actions;
		private bool replaceEmptyImageData = false;
		private bool addNewImages = false;

		public ImageDocActions Actions {
			get { return actions; }
			set { actions = value; }
		}

		public bool ReplaceEmptyImageData {
			get { return replaceEmptyImageData; }
			set { replaceEmptyImageData = value; }
		}

		public bool AddNewImages {
			get { return addNewImages; }
			set { addNewImages = value; }
		}

		public List<string> PatientNumbers {
			get { return patientNumbers; }
			set { patientNumbers = value; }
		}

		public List<string> ImageFileNames {
			get { return imageFileNames; }
			set { imageFileNames = value; }
		}

		/// <summary>
		/// Cancel the job
		/// </summary>
		public void Cancel() {
			cancelled = true;
		}

		/// <summary>
		/// Initialized any counters or rest job state
		/// </summary>
		public void Init() {
			cancelled = false;
			errorCount = 0;
			isProcessing = true;
		}

		public bool IsProcessing {
			get {
				return isProcessing;
			}
			set {
				isProcessing = value;
			}
		}

		public int ErrorCount {
			get { return errorCount; }
			set { errorCount = value; }
		}

		/// <summary>
		/// The main image processing loop.
		/// Generates a batch of images for each patient
		/// </summary>
		public void Process() {
			int progressPosition = 0;
			progressPosition = 0;
			while (progressPosition <= patientNumbers.Count - 1 && !cancelled) {
				try {
					// Create a new batch of images for the patient
					List<ImageDoc> batch;
					//if (replaceEmptyImageData) {
					//	ImageProcessingActions.UpdateEmptyImageData(patientNumbers[progressPosition], imageFileNames);
					//}
					if (addNewImages) {
						batch = ImageProcessingActions.CreateNewBatchOfTestImages(patientNumbers[progressPosition], "", imageFileNames);
						// Save the images to the database
						foreach (ImageDoc doc in batch) {
							ReplaceOneResult result = actions.Save(doc);
							if (result.UpsertedId != null) {
								doc.Id = result.UpsertedId.AsObjectId;
							}
						}
					}
				}
				catch (Exception ex) {
					RaiseProgress(patientNumbers[progressPosition], ProgressEvents.ErrorOccurred, progressPosition);
					errorCount++;
				}
				finally {
					progressPosition++;
					// Flag progress to any handlers
					RaiseProgress(patientNumbers[progressPosition], ProgressEvents.ProcessedItem, progressPosition + 1);			
				}
			}
			isProcessing = false;
			if (!cancelled) {
				RaiseProgress(null, ProgressEvents.Completed, progressPosition);
			}
			else {
				RaiseProgress(null, ProgressEvents.Cancelled, progressPosition);
			}
		}

		/// <summary>
		/// Trigger any progress event handlers
		/// </summary>
		/// <param name="patientNumber">Current patient number being processed</param>
		/// <param name="progressType">The nature of processing event</param>
		/// <param name="progressPosition">The current position in the processing list</param>
		private void RaiseProgress(string patientNumber, ProgressEvents progressType, int progressPosition) {
			if (Progress != null) {
				Progress(this, new ProgressEventArgs(patientNumber, progressPosition, progressType));
			}
		}
	}
}
