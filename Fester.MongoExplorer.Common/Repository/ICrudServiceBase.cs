using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fester.MongoExplorer.Common.Repository {

	public interface ICrudServiceBase<T,K> {

		/// <summary>
		/// Get a single object using its primary identifying key
		/// </summary>
		/// <param name="pimaryKey"></param>
		/// <returns></returns>
		T Get(K primaryKey);

		/// <summary>
		/// Get a list of objects, filtering by a named field and a filter value
		/// </summary>
		/// <param name="fieldName"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		List<T> GetList(string fieldName, string value);

		ReplaceOneResult Save(T item);

	}
}
