using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace Fester.MongoExplorer.Plugin {

	/// <summary>
	/// Provides dynamic plugin assembly loading for Mongo Explorer
	/// (primarily for the diary)
	/// This uses the "MEF" technique (Managed Extensibility Framework)
	/// see "https://msdn.microsoft.com/en-us/library/dd460648(v=vs.110).aspx"
	/// Basically allows dynamic discovery of extensions/plugins without configuration
	/// </summary>
	public class MongoPluginFactory {

		private CompositionContainer container;

		/// <summary>
		/// Contructor for the factory
		/// </summary>
		public MongoPluginFactory() {
			// build assembly catalog
			var mongoPlugins = @"plugins\*.dll";
			// look in current folder
			var dirCatalog = new DirectoryCatalog(".", mongoPlugins);
			if (dirCatalog.LoadedFiles.Count == 0) {
				// look in web service "bin" folder (root does not contain dlls)
				dirCatalog = new DirectoryCatalog("bin", mongoPlugins);
			}
			// compose the plugin classes
			container = new CompositionContainer(dirCatalog);
			container.ComposeParts(this);
			// loads all plugins and builds a list of names
			LoadAllPlugins();
		}

		/// <summary>
		/// List of plugins
		/// Composed at runtime
		/// </summary>
		[ImportMany]
		public IEnumerable<Lazy<IMongoPlugin, IMongoPluginMetaData>> Plugins { get; set; }

		/// <summary>
		/// Get plugin based on its name
		/// </summary>
		/// <param name="fullName">plugin assembly name</param>
		/// <returns>plugin object or null if not found</returns>
		public IMongoPlugin GetPlugin(string fullName) {
			var plugin = Plugins.Where(s => s.Metadata.Name.Equals(fullName, StringComparison.OrdinalIgnoreCase)).Select(s => s.Value).FirstOrDefault();
			return plugin;
		}

		private List<string> pluginNames = new List<string>();

		/// <summary>
		/// Simple list of plugin names
		/// </summary>
		public List<string> PluginNames {
			get { return pluginNames; }
		}

		/// <summary>
		/// Load all plugins and create a list of their names
		/// to be used to access them from the client application
		/// </summary>
		public void LoadAllPlugins() {
			foreach (var plugin in Plugins) {
				pluginNames.Add(plugin.Value.PluginName);
			}
		}


	}

}