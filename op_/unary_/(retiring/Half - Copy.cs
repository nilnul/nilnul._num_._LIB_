using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;

namespace nilnul.num.op_
{
	public class Half : nilnul.num.OpI
	{

		static public readonly Half Singleton = SingletonByDefault<Half>.Instance;

		public Natural.Asserted eval(Natural.Asserted arg)
		{
			return arg.toHalf();
			throw new NotImplementedException();
		}
	}
}
