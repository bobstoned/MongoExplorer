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



	}
}
