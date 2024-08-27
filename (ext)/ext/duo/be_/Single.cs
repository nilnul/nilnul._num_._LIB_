using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit;

namespace nilnul.num.ext_.duo.be_
{
	public class Single : BeI
	{

		static public readonly Single Singleton = SingletonByDefault<Single>.Instance;

		public bool be(Duo obj)
		{
			return  obj.Item1==obj.Item2;
			throw new NotImplementedException();
		}

		


	}
}
