using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver.Builders;
using MongoDB.Driver;
using Fester.MongoExplorer.Common;
using Fester.MongoExplorer.Plugin;
using System.ComponentModel.Composition;

namespace Fester.MongoExplorer.Plugin.Collection {

	[Export(typeof(IMongoPlugin)), ExportMetadata("Name", "Mongo Collection Plugin")]
	public class CollectionPlugin: MongoPluginBase {

		[System.ComponentModel.Composition.ImportingConstructor]
		public CollectionPlugin() {
			SetIdentity();
		}

		public CollectionPlugin(MongoExplorerSession explorer): base(explorer) {
			this.explorer = explorer;
			SetIdentity();
		}

		private void SetIdentity() {
			this.pluginName = "Mongo Collection Plugin";
			this.pluginDescription = "Explore database collections";
		}

		protected override void SetPluginControl() {
			base.pluginControl = new CollectionPluginControl();
			base.SetPluginControl();	
		}

		protected override void Connected() {
			base.pluginControl.Connected();
		}



	}
}
