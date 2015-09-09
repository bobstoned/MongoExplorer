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
using IMAGING = Blithe.Common.Imaging;
using Fester.MongoExplorer.Plugin.MongoImaging.Collections;

namespace Fester.MongoExplorer.Plugin.MongoImaging {

	[Export(typeof(IMongoPlugin)), ExportMetadata("Name", "Imaging Plugin")]
	public class MongoImagingPlugin: MongoPluginBase {

		#region Constructors

		/// <summary>
		/// Need this default constructor for MEF plugin instantiation
		/// </summary>
		[System.ComponentModel.Composition.ImportingConstructor]
		public MongoImagingPlugin() {
			SetIdentity();
		}

		public MongoImagingPlugin(MongoExplorerSession explorer)
			: base(explorer) {
			this.explorer = explorer;
			SetIdentity();
		}

		#endregion

		#region Plugin stuff

		private void SetIdentity() {
			this.pluginName = "Imaging Plugin";
			this.pluginDescription = "Imaging module plugin";
		}

		protected override void SetPluginControl() {
			base.pluginControl = new ImagingPluginControl();
			base.SetPluginControl();
		}

		/// <summary>
		/// Gets all templates using the async task ("Result" will wait to finish!)
		/// </summary>
		public List<ScriptTemplate> GetTemplates() {
			var templates = this.GetTemplatesAsync().Result;
			return templates;
			/*
			var templateNames = new List<string>();
			foreach (ScriptTemplate template in templates) {
				templateNames.Add(template.Name);
			}
			return templateNames;
			 **/
		}

		/// <summary>
		/// Gets templates asynchronously (note the "await" keyword)
		/// "ConfigureAwait(false)" won't continue to use the current thread for 
		/// susequent processes (causes hang otherwise)
		/// </summary>
		/// <returns></returns>
		private async Task<List<ScriptTemplate>> GetTemplatesAsync() {
			var collection = explorer.Database.GetCollection<ScriptTemplate>("script_template");
			var sort = Builders<ScriptTemplate>.Sort.Ascending("Name");
			var filter = Builders<ScriptTemplate>.Filter.Gte("Name", "");
			//var projection = Builders<ScriptTemplate>.Projection.Include("ScriptRegions.HighLightRegion").Exclude("_id");
			return await collection.FindAsync<ScriptTemplate>(f => f.Name != "").Result.ToListAsync();
		}

		private async void InsertAsync(ScriptTemplate template) {
			var collection = explorer.Database.GetCollection<ScriptTemplate>("script_template");
			await collection.InsertOneAsync(template);
		}

		public void Insert(string name, string description, string regions) {
			ScriptTemplate template = new ScriptTemplate() {
				Name = name,
				Description = description
			};
			InsertAsync(template);
		}


		#endregion

		#region Imaging Stuff

		#endregion

	}
}
