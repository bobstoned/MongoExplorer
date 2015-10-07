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

namespace Fester.MongoExplorer.Plugin.MongoShell {
	public partial class MongoShellPluginControl : PluginControl {

		public MongoShellPluginControl() {
			InitializeComponent();
			scriptBindingSource.DataSource = MongoScriptFile.Scripts;
		}

		private MongoShellPlugin GetPlugin() {
			return this.Plugin as MongoShellPlugin;
		}

		private void executeButton_Click(object sender, EventArgs e) {
			try {
				string execScript = Current.GetExecutableScript();
				//queryTextBox.Text = execScript;
				var result = GetPlugin().Explorer.Server.GetDatabase(GetPlugin().Explorer.DatabaseName).Eval(execScript);
				string jsonPretty = result.ToJson(new JsonWriterSettings { Indent = true });
				commandResultsText.Text = jsonPretty;
			}
			catch (Exception ex) {
				MessageBox.Show("Could not execute shell command", "Shell Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		MongoScriptFile Current {
			get { 
				return scriptBindingSource.Current as MongoScriptFile; 
			}
		}

		private void scriptListBox_SelectedIndexChanged(object sender, EventArgs e) {
			//queryTextBox.Text = Current.Content;
		}



	}
}
