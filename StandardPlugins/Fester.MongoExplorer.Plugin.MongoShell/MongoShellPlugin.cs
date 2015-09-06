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

namespace Fester.MongoExplorer.Plugin.MongoShell {

	[Export(typeof(IMongoPlugin)), ExportMetadata("Name","Mongo Shell Plugin")]
	public class MongoShellPlugin: MongoPluginBase {

		[System.ComponentModel.Composition.ImportingConstructor]
		public MongoShellPlugin() {
			SetIdentity();
		}

		public MongoShellPlugin(MongoExplorerSession explorer): base(explorer) {
			this.explorer = explorer;
			SetIdentity();
		}

		private void SetIdentity() {
			this.pluginName = "Mongo Shell Plugin";
			this.pluginDescription = "Execute Mongo DB shell commands direct from the explorer";
		}

		protected override void SetPluginControl() {
			base.pluginControl = new MongoShellPluginControl();
			base.SetPluginControl();
		}

		public List<BsonDocument> RemoveLowestScore(int score) {
			var collection = explorer.Database.GetCollection<BsonDocument>("students");		
			List<BsonDocument> students = GetStudents(score).Result;
			foreach (BsonDocument student in students) {
				// create a filter to find the student by their "_id"
				var filter = Builders<BsonDocument>.Filter.Eq("_id", student["_id"]);
				// convert the scores document to an arry array 
				BsonArray newScores = student["scores"].AsBsonArray;
				// get the lowest homework score
				BsonValue minScore = newScores.Where(o=>o["type"].AsString == "homework").Min(s => s["score"]);
				if (minScore != null) {
					// remove the lowest score from the array
					BsonValue doc = newScores.FirstOrDefault(s => s["score"].AsDouble == minScore.AsDouble);
					newScores.Remove(doc);
				}
				// replace the scores array 
				student["scores"] = newScores;
				// save the student document
				var r = collection.ReplaceOneAsync(filter, student);
			}
			return students;
		}

		public async Task<List<BsonDocument>> GetStudents(int score) {
			var collection = explorer.Database.GetCollection<BsonDocument>("students");
			var sort = Builders<BsonDocument>.Sort.Descending("scores.score");
			var filter = Builders<BsonDocument>.Filter.Gte("scores.score", score);
			return await collection.Find(filter).Sort(sort).ToListAsync().ConfigureAwait(false);
		}


	}
}
