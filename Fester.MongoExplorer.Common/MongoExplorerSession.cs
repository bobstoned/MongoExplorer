using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Shared;
using System.Data;

namespace Fester.MongoExplorer.Common {

	public class MongoExplorerSession {

		public MongoExplorerSession() {

		}

		private string serverName;
		private int port;
		private MongoClient client;
		private IMongoDatabase database;
		private string databaseName;
		private List<string> collectionNames;
		private string selectedCollection;

		public void SetServer(string serverName, int port) {
			this.port = port;
			this.ServerName = serverName;
		}

		public string ServerName {
			get { return serverName; }
			set {
				if (!string.IsNullOrEmpty(value) && serverName != value) {
					serverName = value;
					try {
						//server = GetServer(serverName);
						client = GetClient(serverName);
					}
					catch (Exception ex) {
						throw new Exception("Could not conect to server", ex);
					}
				}
			}
		}

		public int Port {
			get { return port; }
			set { port = value; }
		}

		/// <summary>
		/// Server and port as one address
		/// </summary>
		public string ServerAndPort {
			get { 
				return string.Format("{0}:{1}", serverName, port); 
			}
		}

		public string DatabaseName {
			get { return databaseName; }
			set {
				if (!string.IsNullOrEmpty(value) && databaseName != value) {
					databaseName = value;
					database = GetDatabase(databaseName);
					var colls = GetCollectionNames().Result;
					collectionNames = new List<string>();
					foreach (BsonDocument doc in colls) {
						collectionNames.Add(doc["name"].AsString);
					}
				}
			}
		}

		public MongoServer Server {
			get {
				return Client.GetServer(); 
			}
		}

		public MongoClient Client {
			get {
				return client;
			}
		}

		public IMongoDatabase Database {
			get { return database; }
			set { database = value; }
		}

		public List<string> CollectionNames {
			get { return collectionNames; }
			set { collectionNames = value; }
		}

		public string SelectedCollection {
			get { return selectedCollection; }
			set { selectedCollection = value; }
		}

		public void Refresh() {
			var colls = GetCollectionNames().Result;
			collectionNames = new List<string>();
			foreach (BsonDocument doc in colls) {
				collectionNames.Add(doc["name"].AsString);
			}
		}

		public MongoConnection GetConnection() {
			return new MongoConnection(){
				ServerName = this.serverName,
				Port = this.port,
				DatabaseName = this.databaseName
			};
		}

		/// <summary>
		/// Gets the collection as a data table
		/// </summary>
		/// <param name="collectionName">name of the database collection</param>
		/// <param name="limit">limit the documents to return</param>
		/// <returns></returns>
		public DataTable GetCollection(string collectionName, int limit) {
			var documents = GetCollectionAsync(collectionName, limit).Result;
			return GetDataTableFromBSONList(collectionName, documents);
		}

		/// <summary>
		/// Gets a mongo db collection as a data table
		/// </summary>
		/// <param name="collectionName">name of the collection</param>
		/// <returns></returns>
		public async Task<List<BsonDocument>> GetCollectionAsync(string collectionName, int limit) {
			var collection = database.GetCollection<BsonDocument>(collectionName);
			return await collection.Find(new BsonDocument()).Limit(limit).ToListAsync().ConfigureAwait(false);
		}

		private MongoClient GetClient(string serverName) {
			try {
				var client = new MongoClient(string.Format("{0}:{1}", serverName, this.port));
				return client;
			}
			catch (Exception ex) {
				throw ex;
			}
		}

		private IMongoDatabase GetDatabase(string databaseName) {
			return client.GetDatabase(databaseName);
		}

		private async Task<List<BsonDocument>> GetCollectionNames() {
			var colls = await database.ListCollectionsAsync().Result.ToListAsync();
			return colls;
		}

		public List<string> GetDatabaseNames() {
			var names = this.GetDatabaseNamesAsync().Result;
			var databaseNames = new List<string>();
			foreach (BsonDocument doc in names) {
				databaseNames.Add(doc["name"].AsString);
			}
			return databaseNames;
		}

		private async Task<List<BsonDocument>> GetDatabaseNamesAsync() {
			var dbs = await client.ListDatabasesAsync().Result.ToListAsync();
			return dbs;
		}

		/// <summary>
		/// Translate the BSONDocument array into a data table
		/// suitable as a data source
		/// </summary>
		/// <param name="cursor"></param>
		/// <returns></returns>
		public DataTable GetDataTableFromMongoCursor(BsonDocument cursor) {
			return new DataTable();
			/*
			if (cursor != null && cursor.Count() > 0) {
				DataTable dt = new DataTable(cursor.ToString());
				foreach (BsonDocument doc in cursor) {
					foreach (BsonElement elm in doc.Elements) {
						if (!dt.Columns.Contains(elm.Name)) {
							dt.Columns.Add(new DataColumn(elm.Name));
						}
					}
					DataRow dr = dt.NewRow();
					foreach (BsonElement elm in doc.Elements) {
						dr[elm.Name] = elm.Value;
					}
					dt.Rows.Add(dr);
				}
				return dt;
			}
			return null;
			 */
		}

		/// <summary>
		/// Translate the BSONDocument array into a data table
		/// suitable as a data source
		/// </summary>
		/// <param name="cursor"></param>
		/// <returns></returns>
		public DataTable GetDataTableFromBSONList(string collectionName, List<BsonDocument> documents) {
			if (documents != null && documents.Count() > 0) {
				DataTable dt = new DataTable(collectionName);
				foreach (BsonDocument doc in documents) {
					foreach (BsonElement elm in doc.Elements) {
						if (!dt.Columns.Contains(elm.Name)) {
							dt.Columns.Add(new DataColumn(elm.Name));
						}
					}
					DataRow dr = dt.NewRow();
					foreach (BsonElement elm in doc.Elements) {
						dr[elm.Name] = elm.Value;
					}
					dt.Rows.Add(dr);
				}
				return dt;
			}
			return null;
		}

		public async Task<IAsyncCursor<BsonDocument>> GetCollectionRowsAsync(string collectionName) {
			var collection = database.GetCollection<BsonDocument>(collectionName);
			List<BsonDocument> list = new List<BsonDocument>();
			var options = new FindOptions<BsonDocument> {
				// Our cursor is a tailable cursor and informs the server to await
				CursorType = CursorType.NonTailable
			};

			// Initially, we don't have a filter. An empty BsonDocument matches everything.
			BsonDocument filter = new BsonDocument();
			// Start the cursor and wait for the initial response
			using (var cursor = await collection.FindAsync(filter, options)) {
				// This callback will get invoked with each new document found
				await cursor.ForEachAsync(document => {
					list.Add(document);		
				});
				return cursor;
			}
			
		}


	}
}
