using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fester.MongoExplorer.Common {

	public class MongoConnection {

		private string serverName;
		private string databaseName;
		private int port;

		public string ServerName {
			get { return serverName; }
			set { serverName = value; }
		}

		public string DatabaseName {
			get { return databaseName; }
			set { databaseName = value; }
		}

		public int Port {
			get { return port; }
			set { port = value; }
		}

	}
}
