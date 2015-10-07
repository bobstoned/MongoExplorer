using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Fester.Common {

	/// <summary>
	/// Simple data generation wrapper for a background thread.
	/// Allows a data generation process to be run on the 
	/// background thread with progress handling.
	/// </summary>
	public class ThreadedDataGeneration {

		public ThreadedDataGeneration(IDataGeneration generateData) {
			this.generateData = generateData;
		}

		private IDataGeneration generateData;

		/// <summary>
		/// A data generation class which may be threaded
		/// </summary>
		public IDataGeneration GenerateData {
			get { return generateData; }
			set { generateData = value; }
		}

		/// <summary>
		/// Configures the background thread to run and starts 
		/// </summary>
		public void Run() {
			using (BackgroundWorker processItemThread = new BackgroundWorker()) {
				processItemThread.DoWork += processItemThread_DoWork;
				processItemThread.RunWorkerCompleted += processItemThread_RunWorkerCompleted;
				// Indicate that processing has begun
				generateData.IsProcessing = true;
				processItemThread.RunWorkerAsync(generateData);
			}
		}

		/// <summary>
		/// Main Thread process has completed, cleanup and set flags
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void processItemThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
			// TODO: Report completed ?
			generateData.IsProcessing = false;
		}

		private void processItemThread_DoWork(object sender, DoWorkEventArgs e) {
			// Initialize the data generation object, could be lengthy
			(e.Argument as IDataGeneration).Init();
			// Run the process from the IDataGeneration object
			(e.Argument as IDataGeneration).Process();
		}

	}
}
