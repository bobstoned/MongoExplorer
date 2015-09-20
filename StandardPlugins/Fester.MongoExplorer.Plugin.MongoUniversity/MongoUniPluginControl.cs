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
using System.Threading;

namespace Fester.MongoExplorer.Plugin.MongoUniversity {
	public partial class MongoUniPluginControl : PluginControl {

		public MongoUniPluginControl() {
			InitializeComponent();
		}

		private void removeButton_Click(object sender, EventArgs e) {
			List<BsonDocument> result = (this.Plugin as MongoUniversityPlugin).RemoveLowestScore((int)scoreUpDown.Value);
			resultsGrid.AutoGenerateColumns = true;
			resultsGrid.DataSource = (this.Plugin as MongoUniversityPlugin).Explorer.GetDataTableFromBSONList("scores", result);
		}

		private void resultsGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0) {
				documentTextBox.Text = GeneralUtilities.FormatJson(
					(string)resultsGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
		}

		// cancellation token source for obtaining a token for cancelling an async job
		CancellationTokenSource source;
		// job counters updated by the processing job
		MongoUniversityPlugin.JobCounters counters;

		private async void getImagesButton_Click(object sender, EventArgs e) {
			// start the timer for updating the UI
			progressTimer.Enabled = true;
			cancelButton.Enabled = true;
			getImagesButton.Enabled = false;
			// Get and process all images, but don't block the UI thread
			try {
				// Create to get a cancellation token for the job
				source = new CancellationTokenSource();
				// Create a job counters object, to be updated by the async task
				counters = new MongoUniversityPlugin.JobCounters();
				int count = await (this.Plugin as MongoUniversityPlugin).GetImages(source.Token, counters);
				// this will wait for completion of the above (it's async though!)
				countTextBox.Text = count.ToString();
			}
			catch (OperationCanceledException ex) {
				MessageBox.Show("The operation was cancelled");
				source.Dispose();
			}
			finally {
				// stop the timer
				progressTimer.Enabled = false;
				cancelButton.Enabled = false;
				getImagesButton.Enabled = true;
				UpdateCounters();
			}

		}

		private void progressTimer_Tick(object sender, EventArgs e) {
			UpdateCounters();
		}

		private void UpdateCounters() {
			removedTextBox.Text = counters.Orphaned.ToString();
			countTextBox.Text = counters.Processed.ToString();
			kittensTextBox.Text = counters.Kittens.ToString();
		}

		private void cancelButton_Click(object sender, EventArgs e) {
			source.Cancel();
		}



	}
}
