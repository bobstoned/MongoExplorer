using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fester.MongoExplorer.Plugin.MongoImaging.Collections;
using Fester.MongoExplorer.Common.Repository;

namespace Fester.MongoExplorer.Plugin.MongoImaging.Repository {
	public interface IBaseImageService: ICrudServiceBase<ImageDoc, int> {

	}
}
