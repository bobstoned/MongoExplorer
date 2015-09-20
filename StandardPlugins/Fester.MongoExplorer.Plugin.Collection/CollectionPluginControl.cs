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
using MongoDB.Bson.IO;

namespace Fester.MongoExplorer.Plugin.Collection {
	public partial class CollectionPluginControl : PluginControl {

		public CollectionPluginControl() {
			InitializeComponent(); 
		}

		private CollectionPlugin ThisPlugin {
			get { return this.Plugin as CollectionPlugin; }
		}

		public override void Connected() {
			collectionListBox.DataSource = ThisPlugin.Explorer.CollectionNames;
		}

		private void collectionListBox_SelectedIndexChanged(object sender, EventArgs e) {
			ThisPlugin.Explorer.SelectedCollection = ThisPlugin.Explorer.CollectionNames.Count > 0 ? (string)collectionListBox.SelectedItem : string.Empty;
			if (!string.IsNullOrEmpty(ThisPlugin.Explorer.SelectedCollection)) {
				collectionView.AutoGenerateColumns = true;
				collectionView.DataSource = ThisPlugin.Explorer.GetCollection(ThisPlugin.Explorer.SelectedCollection, (int)maxDocsUpDown.Value);
				collectionNameTextBox.Text = ThisPlugin.Explorer.SelectedCollection;
				documentCountTextBox.Text = (collectionView.DataSource as DataTable).Rows.Count.ToString();
			}
		}

		private void refreshButton_Click(object sender, EventArgs e) {
			ThisPlugin.Explorer.Refresh();
			collectionListBox.DataSource = ThisPlugin.Explorer.CollectionNames;
		}

		private void collectionView_CellClick(object sender, DataGridViewCellEventArgs e) {
			if (e.RowIndex > -1) {
				documentTextBox.Text = GeneralUtilities.FormatJson((string)collectionView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
		}



	}
}
