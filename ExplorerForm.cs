﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Shared;
using Fester.MongoExplorer.Common;
using Fester.MongoExplorer.Plugin;

namespace Fester.MongoExplorer.App {
	public partial class ExplorerForm : Form {
		public ExplorerForm() {
			InitializeComponent();
			CreatePlugins();
			Tools.ApplyStyle(this, Color.Gray, Color.DarkGray, Color.LightSalmon, Color.DarkRed, Color.White);
		}

		List<Control> buttons = new List<Control>();

		private MongoExplorerSession explorer = new MongoExplorerSession();

		private void connectButton_Click(object sender, EventArgs e) {
			var connection = LoginDialog.ShowModal(explorer.GetConnection());
			if (connection != null) {
				explorer.SetServer(connection.ServerName, connection.Port);
				explorer.DatabaseName = connection.DatabaseName;
				serverTextBox.Text = explorer.ServerAndPort;
				databaseTextBox.Text = explorer.DatabaseName;
				collectionListBox.DataSource = explorer.CollectionNames;
			}
		}

		private void collectionListBox_SelectedIndexChanged(object sender, EventArgs e) {
			explorer.SelectedCollection = explorer.CollectionNames.Count > 0 ? (string)collectionListBox.SelectedItem : string.Empty;
			if (!string.IsNullOrEmpty(explorer.SelectedCollection)) {
				collectionView.AutoGenerateColumns = true;
				collectionView.DataSource = explorer.GetCollection(explorer.SelectedCollection, (int)maxDocsUpDown.Value);
				collectionNameTextBox.Text = explorer.SelectedCollection;
				documentCountTextBox.Text = (collectionView.DataSource as DataTable).Rows.Count.ToString();
			}
		}

		private void refreshButton_Click(object sender, EventArgs e) {
			explorer.Refresh();
			collectionListBox.DataSource = explorer.CollectionNames;
		}

		private void imporButton_Click(object sender, EventArgs e) {
			CollectionActions actions = new CollectionActions(explorer.Server, explorer.Database);
			List<Dictionary<string, BsonValue>> rows = new List<Dictionary<string, BsonValue>>();			
			for(int i=1;i<=10;i++) {
				Dictionary<string, BsonValue> row = new Dictionary<string, BsonValue>();
				row.Add("batchId", new BsonInt32(i));
				row.Add("scanDate", new BsonDateTime(DateTime.Now));
				rows.Add(row);
			}
			//List<BsonDocument> documents = actions.Create(importcolNameTextBox.Text, rows);
			//importView.AutoGenerateColumns = true;
			//importView.DataSource = explorer.GetDataTableFromBSONList("scans", documents);
		}

		MongoPluginFactory pluginFactory = new MongoPluginFactory();

		private void CreatePlugins() {
			var names = pluginFactory.PluginNames;
			pluginListBox.DataSource = names;
		}

		private void collectionView_CellClick(object sender, DataGridViewCellEventArgs e) {
			documentTextBox.Text = GeneralUtilities.FormatJson((string)collectionView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
		}

		List<IMongoPlugin> plugins = new List<IMongoPlugin>();

		private void pluginListBox_SelectedIndexChanged(object sender, EventArgs e) {
			string pluginName = (string)pluginListBox.SelectedItem;
			if (string.IsNullOrEmpty(pluginName)) {
				return;
			}
			if (plugins.FirstOrDefault(p => p.PluginName == pluginName) == null) {
				var plugin = pluginFactory.GetPlugin(pluginName);
				plugins.Add(plugin);
				pluginHost.Plugin = plugin;
			}
			else {
				pluginHost.Plugin = plugins.FirstOrDefault(p => p.PluginName == pluginName);
			}
			pluginHost.Plugin.Explorer = this.explorer;
			Tools.ApplyStyle(pluginHost, Color.Gray, Color.DarkGray, Color.LightSalmon, Color.DarkRed, Color.White);
			Tools.SetPanelStyling(pluginHost, Color.DarkGray);
		}

		private void closeButton_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void aboutMenuItem_Click(object sender, EventArgs e) {
			AboutDialog.ShowAboutDialog();
		}

		private void queryTabControl_DrawItem(object sender, DrawItemEventArgs e) {
			ChangeTabColor(e);
		}

		private void ChangeTabColor(DrawItemEventArgs e) {
			Font TabFont;
			Brush BackBrush = new SolidBrush(Color.Green); //Set background color
			Brush ForeBrush = new SolidBrush(Color.Yellow);//Set foreground color
			if (e.Index == this.queryTabControl.SelectedIndex) {
				TabFont = new Font(e.Font, FontStyle.Italic | FontStyle.Bold);
			}
			else {
				TabFont = e.Font;
			}
			string TabName = this.queryTabControl.TabPages[e.Index].Text;
			StringFormat sf = new StringFormat();
			sf.Alignment = StringAlignment.Center;
			e.Graphics.FillRectangle(BackBrush, e.Bounds);
			Rectangle r = e.Bounds;
			r = new Rectangle(r.X, r.Y + 3, r.Width, r.Height - 3);
			e.Graphics.DrawString(TabName, TabFont, ForeBrush, r, sf);
			//Dispose objects
			sf.Dispose();
			if (e.Index == this.queryTabControl.SelectedIndex) {
				TabFont.Dispose();
				BackBrush.Dispose();
			}
			else {
				BackBrush.Dispose();
				ForeBrush.Dispose();
			}
		}

	}
}
