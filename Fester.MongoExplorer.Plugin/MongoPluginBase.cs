using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fester.MongoExplorer.Common;

namespace Fester.MongoExplorer.Plugin {

	public class MongoPluginBase: IMongoPlugin {

		public MongoPluginBase() {
			SetPluginControl();
		}

		public MongoPluginBase(MongoExplorerSession explorer) {
			this.explorer = explorer;
			SetPluginControl();
		}

		protected MongoExplorerSession explorer;

		public MongoExplorerSession Explorer {
			get { return explorer; }
			set { explorer = value; }
		}

		protected PluginControl pluginControl;

		public PluginControl PluginControl {
			get { return pluginControl; }
		}

		protected virtual void SetPluginControl() {
			pluginControl.Plugin = this;
		}

		protected string pluginName = "MongoPluginBase";
		protected string pluginDescription = "MongoPluginBase";

		public string PluginName {
			get { return pluginName; }
		}

		public string PluginDescription {
			get { return pluginDescription; }
		}

	}
}
