using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fester.MongoExplorer.App {
	public class GeneralUtilities {

		public static string FormatJson(string json) {
			try {
				dynamic parsedJson = JsonConvert.DeserializeObject(json);
				return JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
			}
			catch {
				return json;
			}
		}

	}
}
