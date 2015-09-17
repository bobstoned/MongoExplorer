using Fester.MongoExplorer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fester.MongoExplorer.Common.Repository {
	public interface ICrudMongoExplorer {

		MongoExplorerSession Session { get; set; }

	}
}
