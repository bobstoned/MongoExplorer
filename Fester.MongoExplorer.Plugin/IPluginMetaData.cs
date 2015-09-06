using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fester.MongoExplorer.Plugin {

	/// <summary>
	/// Allows meta data, including a name to be attached to the plugin class
	/// </summary>
	public interface IMongoPluginMetaData {
		string Name { get; }
	}

}