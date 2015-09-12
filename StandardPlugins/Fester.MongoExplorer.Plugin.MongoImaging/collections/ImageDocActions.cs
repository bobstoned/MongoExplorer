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
namespace Fester.MongoExplorer.Plugin.MongoImaging.Collections {

	public class ImageDocActions {

		public ImageDocActions(MongoExplorerSession explorer) {
			this.explorer = explorer;
		}

		MongoExplorerSession explorer;

		public MongoExplorerSession Explorer {
			get { return explorer; }
			set { explorer = value; }
		}

		/// <summary>
		/// Gets all templates using the async task ("Result" will wait to finish!)
		/// </summary>
		public List<ImageDoc> Get() {
			var docs = this.GetAsync().Result;
			return docs;
		}

		/// <summary>
		/// Gets templates asynchronously (note the "await" keyword)
		/// "ConfigureAwait(false)" won't continue to use the current thread for 
		/// susequent processes (causes hang otherwise)
		/// </summary>
		/// <returns></returns>
		private async Task<List<ImageDoc>> GetAsync() {
			var collection = explorer.Database.GetCollection<ImageDoc>("image");
			var sort = Builders<ImageDoc>.Sort.Ascending("name");
			var filter = Builders<ImageDoc>.Filter.Gte("name", "");
			//var projection = Builders<ScriptTemplate>.Projection.Include("ScriptRegions.HighLightRegion").Exclude("_id");
			return await collection.FindAsync<ImageDoc>(filter).Result.ToListAsync();
		}

	}
}
