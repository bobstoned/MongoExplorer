using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fester.MongoExplorer.Plugin {
	public partial class PluginControl : UserControl {
		public PluginControl() {
			InitializeComponent();
		}

		private MongoPluginBase plugin;

		public MongoPluginBase Plugin {
			get { return plugin; }
			set { plugin = value; }
		}

		/// <summary>
		/// override to handle database connection
		/// </summary>
		public virtual void Connected() {

		}

	}
}
