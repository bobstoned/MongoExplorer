using Fester.MongoExplorer.Plugin.MongoImaging.Collections;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fester.MongoExplorer.Common.Repository;
using MongoDB.Driver.Builders;

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
		public async Task<List<ImageDoc>> GetListAsync(string fieldName, string value) {
			var collection = session.Database.GetCollection<ImageDoc>(collectionName);
			var sort = Builders<ImageDoc>.Sort.Ascending(fieldName);
			var filter = Builders<ImageDoc>.Filter;
			var filterLike = filter.Regex(fieldName, @"/" + value + @"/");
			return await collection.Find<ImageDoc>(filterLike).ToListAsync().ConfigureAwait(false);
		}

		/// <summary>
		/// Gets templates asynchronously (note the "await" keyword)
		/// "ConfigureAwait(false)" won't continue to use the current thread for 
		/// susequent processes (causes hang otherwise)
		/// </summary>
		/// <returns></returns>
		public async Task<List<ImageDoc>> GetListAsync(ImageDoc.ImageFilter filter) {
			var collection = session.Database.GetCollection<ImageDoc>(collectionName);
			var sort = Builders<ImageDoc>.Sort.Ascending(i => i.Name);
			var builder = Builders<ImageDoc>.Filter;
			var filterLike = builder.Regex("name", @"/" + filter.Name + @"/");
			if (filter.Width > 0) {
				filterLike = filterLike & builder.Gt("width", filter.Width);
			}
			if (filter.Height > 0) {
				filterLike = filterLike & builder.Gt("height", filter.Height);
			}
			if (filter.Size > 0) {
				filterLike = filterLike & builder.Gt("size", filter.Height);
			}
			return await collection.Find<ImageDoc>(filterLike).ToListAsync().ConfigureAwait(false);
		}

		/// <summary>
		/// Save the image document, replacing the original.
		/// NOTE: Had many issues with this. Setting the "_id" column in code before inserting.
		/// Doesn't seem to ever ignore the default value of "ObjectId" 
		/// even with the 
		/// </summary>
		/// <param name="doc"></param>
		/// <returns></returns>
		private async Task<ReplaceOneResult> SaveAsync(ImageDoc doc) {
			//var collectionSettings = new MongoCollectionSettings { AssignIdOnInsert = false };
			var collection = session.Database.GetCollection<ImageDoc>(collectionName);
			return await collection.ReplaceOneAsync(
				filter: p => p.Id == doc.Id, 
				options: new UpdateOptions { IsUpsert = true },
				replacement: doc
				).ConfigureAwait(false);
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
