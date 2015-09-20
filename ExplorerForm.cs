using System;
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
			Tools.ApplyStyle("WhiteOut", this, false);
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
			}
		}

		MongoPluginFactory pluginFactory = new MongoPluginFactory();

		private void CreatePlugins() {
			var names = pluginFactory.PluginNames;
			pluginListBox.DataSource = names;
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
			Tools.ApplyStyle("WhiteOut", pluginHost, true);
		}

		private void closeButton_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void aboutMenuItem_Click(object sender, EventArgs e) {
			AboutDialog.ShowAboutDialog();
		}

		private void queryTabControl_DrawItem(object sender, DrawItemEventArgs e) {
		}

	}
}
