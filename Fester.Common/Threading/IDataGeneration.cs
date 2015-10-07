using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fester.Common {

	public interface IDataGeneration {
		void Init();
		void Process() ;
		void Cancel();
		bool IsProcessing {
			get;
			set;
		}
	}


}
