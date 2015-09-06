using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fester.MongoExplorer.Plugin;

namespace Fester.MongoExplorer.App.Plugin {

	public partial class PluginHost : UserControl {

		public PluginHost() {
			InitializeComponent();
		}

		private IMongoPlugin plugin;

		public IMongoPlugin Plugin {
			get { return plugin; }
			set {
				if (value == plugin) {
					return;
				}
				if (plugin != null) {
					this.Controls.Remove(plugin.PluginControl);
				}
				plugin = value;
				if (plugin != null) {
					plugin.PluginControl.Dock = DockStyle.Fill;
					this.Controls.Add(plugin.PluginControl);
				}
			}
		}


	}
}
