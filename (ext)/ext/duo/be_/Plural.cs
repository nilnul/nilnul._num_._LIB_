using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ext_.duo.be_
{
	public class Plural

		:
		 
		BeI
	{

		static public readonly Single Singleton = SingletonByDefault<Single>.Instance;

		public bool be(Duo obj)
		{
			return  obj.Item1 < obj.Item2;
			throw new NotImplementedException();
		}
	}
}
