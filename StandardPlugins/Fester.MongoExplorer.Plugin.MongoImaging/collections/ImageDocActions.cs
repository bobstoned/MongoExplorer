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
using Fester.MongoExplorer.Plugin.MongoImaging.Repository;
using Fester.MongoExplorer.Common.Repository;

namespace Fester.MongoExplorer.Plugin.MongoImaging.Collections {

	/// <summary>
	/// Action class with CRUD operations for image documents
	/// </summary>
	public class ImageDocActions : ICrudServiceBase<ImageDoc, int> {

		private ImageDocRepository repository = new ImageDocRepository();

		/// <summary>
		/// constructor
		/// </summary>
		/// <param name="explorer">the Mongo explorer session provides connection/client and helper functions</param>
		public ImageDocActions(MongoExplorerSession explorer) {
			this.repository.Session = explorer;
		}

		#region Core CRUD based methods

		/// <summary>
		/// Get a single item by its primary key
		/// </summary>
		/// <param name="imageId">primary key</param>
		/// <returns></returns>
		public ImageDoc Get(int imageId) {
			throw new NotImplementedException();
		}

		/// <summary>
		/// Get a list of items using a simple field filter
		/// </summary>
		/// <param name="fieldName">name of the field in the document</param>
		/// <param name="value">filter value</param>
		/// <returns></returns>
		public List<ImageDoc> GetList(string fieldName, string value) {
			return repository.GetList(fieldName, value);
		}

		/// <summary>
		/// Get all image documents
		/// </summary>
		public List<ImageDoc> GetList() {
			return repository.GetList("name", "");
		}

		/// <summary>
		/// Save a single item
		/// </summary>
		public ReplaceOneResult Save(ImageDoc item) {
			return repository.Save(item);
		}

		#endregion


	}
}
