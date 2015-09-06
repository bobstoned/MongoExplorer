using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Shared;

namespace Fester.MongoExplorer.App {

	public class CollectionActions {

		public CollectionActions(MongoServer server, IMongoDatabase database) {
			this.server = server;
			this.database = database;
		}

		private MongoServer server;
		private IMongoDatabase database;

		public MongoServer Server {
			get { return server; }
			set { server = value; }
		}

		public IMongoDatabase Database {
			get { return database; }
			set { database = value; }
		}

		// Insert documents into Mongo
		public List<BsonDocument> Create(string collectionName, List<Dictionary<string, BsonValue>> rows) {
			List<BsonDocument> documents = new List<BsonDocument>();
			// call to MongoDB which create collection 
			var collection = database.GetCollection<BsonDocument>(collectionName);
			foreach (Dictionary<string, BsonValue> row in rows) {
				BsonDocument document = new BsonDocument();
				// create a BSON element for each item in the document
				foreach (string key in row.Keys) {
					BsonElement element = new BsonElement(key, row[key]);
					document.Add(element);
				}					
				// add the document to the result list
				documents.Add(document);
				// insert the document into the Mongo collection
				//collection.Insert(document);
			}
			return documents;
		}


	}
}
