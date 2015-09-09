using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fester.MongoExplorer.Plugin.MongoImaging.Collections {

	[BsonIgnoreExtraElements]
	public class ScriptTemplate {

		[BsonElement("Id")]
		public ObjectId Id { get; set; }

		[BsonElement("Name")]
		public string Name { get; set; }

		[BsonElement("Description")]
		public string Description { get; set; }

		/*
		[BsonElement("ScriptRegions")]
		public List<BsonElement> ScriptRegions { get; set; }
		*/
	}
}
