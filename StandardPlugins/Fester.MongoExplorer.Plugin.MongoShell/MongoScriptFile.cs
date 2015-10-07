using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fester.MongoExplorer.Plugin.MongoShell {

	public class MongoScriptFile {

		private string name;
		private string description;
		private string collection;
		private MongoScriptType type;
		private string content;

		public string Name {
			get { return name; }
			set { name = value; }
		}

		public string Description {
			get { return description; }
			set { description = value; }
		}

		public string Collection {
			get { return collection; }
			set { collection = value; }
		}

		public MongoScriptType Type {
			get { return type; }
			set { type = value; }
		}

		public string Content {
			get { return content; }
			set { content = value; }
		}

		/// <summary>
		/// Get a Mongo shell script wrapped in a function
		/// To allow it to be evaluated into an executable script
		/// </summary>
		/// <returns></returns>
		public string GetExecutableScript() {
			StringBuilder scriptBuilder = new StringBuilder();
			scriptBuilder.AppendLine("function() {");
			scriptBuilder.Append("return ");
			// The actual script
			scriptBuilder.Append(content);
			scriptBuilder.Append(".toArray();");
			scriptBuilder.AppendLine("}");
			return scriptBuilder.ToString();
		}

		static MongoScriptFile() {
			CreateExampleScripts();
		}

		private static List<MongoScriptFile> scripts = new List<MongoScriptFile>();

		public static List<MongoScriptFile> Scripts {
			get { return MongoScriptFile.scripts; }
			set { MongoScriptFile.scripts = value; }
		}

		public static void CreateExampleScripts() {
			MongoScriptFile script;
			script = new MongoScriptFile() {
				Name = "Find Images",
				Type = MongoScriptType.Find,
				Description = "Finds images over a certain width and limits the result size.",
				Collection = "image",
				Content = Properties.Resources.FindImages
			};
			scripts.Add(script);
		}

	}

	public enum MongoScriptType {
		Find,
		FindOne,
		Count,
		Insert,
		Update,
		FindAndModify,
	}

}
