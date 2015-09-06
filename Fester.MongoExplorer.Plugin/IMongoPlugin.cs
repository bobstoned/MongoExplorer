using Fester.MongoExplorer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fester.MongoExplorer.Plugin {

	public interface IMongoPlugin {

		string PluginName { get; }
		string PluginDescription { get;}
		PluginControl PluginControl { get;}
		MongoExplorerSession Explorer { get; set; }

	}
}
