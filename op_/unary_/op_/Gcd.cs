using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;

namespace nilnul.num.op_
{
	public class Gcd
		: OpI
	{
		public Natural.Asserted eval(Natural.Asserted arg)
		{
			return arg;
			throw new NotImplementedException();
		}


		static public readonly Gcd Singleton = SingletonByDefault<Gcd>.Instance;

	}
}
