using Fester.MongoExplorer.Plugin.MongoImaging.Collections;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fester.MongoExplorer.Common.Repository;

namespace Fester.MongoExplorer.Plugin.MongoImaging.Repository {

	/// <summary>
	/// Repository for storing images in Mongo DB
	/// </summary>
	public class ImageDocRepository : IBaseImageService, ICrudMongoExplorer {

		#region Collection constants

		const string primaryKeyName = "name";
		const string collectionName = "image";

		#endregion

		#region IBaseImageService

		/// <summary>
		/// Get a single image by
		/// </summary>
		/// <param name="fieldName"></param>
		/// <param name="primaryKey"></param>
		/// <returns></returns>
		public ImageDoc Get(int primaryKey) {
			var templates = this.GetListAsync(primaryKeyName, primaryKey.ToString()).Result;
			if (templates.Count > 0) {
				return templates[0];
			}
			else {
				return null;
			}
		}

		/// <summary>
		/// Gets all templates using the async task ("Result" will wait to finish!)
		/// </summary>
		public List<ImageDoc> GetList(string fieldName, string value) {
			var docs = this.GetListAsync(fieldName, value).Result;
			return docs;
		}

		public ReplaceOneResult Save(ImageDoc item) {
			var result = this.SaveAsync(item).Result;
			return result;
		}

		#endregion

		#region Async Tasks

		/// <summary>
		/// Gets templates asynchronously (note the "await" keyword)
		/// "ConfigureAwait(false)" won't continue to use the current thread for 
		/// susequent processes (causes hang otherwise)
		/// </summary>
		/// <returns></returns>
		private async Task<List<ImageDoc>> GetListAsync(string fieldName, string value) {
			var collection = session.Database.GetCollection<ImageDoc>(collectionName);
			var sort = Builders<ImageDoc>.Sort.Ascending(fieldName);
			var filter = Builders<ImageDoc>.Filter.Gte(fieldName, value);
			//var projection = Builders<ScriptTemplate>.Projection.Include("ScriptRegions.HighLightRegion").Exclude("_id");
			return await collection.FindAsync<ImageDoc>(filter).Result.ToListAsync();
		}

		/// <summary>
		/// Save the image document, replacing the original
		/// </summary>
		/// <param name="doc"></param>
		/// <returns></returns>
		private async Task<ReplaceOneResult> SaveAsync(ImageDoc doc) {
			var collection = session.Database.GetCollection<ImageDoc>(collectionName);
			var filter = Builders<ImageDoc>.Filter.Eq("name", doc.Name);
			return await collection.ReplaceOneAsync(filter, doc).ConfigureAwait(false);
		}

		#endregion

		#region Mongo Explorer Session - Mongo DB client connection

		private Common.MongoExplorerSession session;

		public Common.MongoExplorerSession Session {
			get {
				return session;
			}
			set {
				session = value;
			}
		}

		#endregion

	}
}
