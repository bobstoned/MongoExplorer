using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fester.MongoExplorer.Common;

namespace Fester.MongoExplorer.App {
	public partial class LoginDialog : Form {
		public LoginDialog() {
			InitializeComponent();
		}

		private MongoExplorerSession session = new MongoExplorerSession();
		private MongoConnection connection = new MongoConnection();
		protected bool connected = false;

		public MongoConnection Connection {
			get { return connection; }
			set { 
				connection = value;
				if (!string.IsNullOrEmpty(connection.ServerName)) {
					databaseComboBox.Text = connection.DatabaseName;
					serverTextBox.Text = connection.ServerName;
					portUpDown.Value = connection.Port;
				}
			}
		}

		public static MongoConnection ShowModal(MongoConnection currentConnection) {
			using (LoginDialog dialog = new LoginDialog()) {
				dialog.Connection = currentConnection;
				dialog.ShowDialog();
				dialog.Close();
				if (dialog.connected) {
					return dialog.Connection;
				}
				else {
					return null;
				}
			}
		}

		private void connectButton_Click(object sender, EventArgs e) {
			try {
				ConnectToServer();
				connection.DatabaseName = databaseComboBox.Text;
				connection.ServerName = serverTextBox.Text;
				connection.Port = (int)portUpDown.Value;
				connected = true;
				UpdateConnectedStatus(connected);
			}
			catch(Exception ex) {
				connected = false;
				MessageBox.Show("Could no connect!", "There was a problem connecting to the server, check your settings",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void ConnectToServer() {
			session.SetServer(serverTextBox.Text, (int)portUpDown.Value);
		}

		private void applyButton_Click(object sender, EventArgs e) {
			// set the server first!
			try {
				ConnectToServer();
				connected = true;
				// Get the database names from the Mongo client
				List<string> names = session.GetDatabaseNames();
				// clear out the exitsing items
				databaseComboBox.Items.Clear();
				// add the new list to the database combo control
				databaseComboBox.Items.AddRange(names.ToArray());
				UpdateConnectedStatus(connected);
			} 
			catch(Exception ex) {
				connected = false;
				UpdateConnectedStatus(false);
			}		
		}

		private void UpdateConnectedStatus(bool connected) {
			connectedLabel.Visible = true;
			connectedLabel.ForeColor = connected ? Color.Green : Color.Red;
			databaseComboBox.Enabled = connected;
			connectButton.Enabled = connected && !string.IsNullOrEmpty(databaseComboBox.Text); 
		}

		private void databaseComboBox_TextChanged(object sender, EventArgs e) {
			connectButton.Enabled = connected && !string.IsNullOrEmpty(databaseComboBox.Text); 
		}


	}
}
