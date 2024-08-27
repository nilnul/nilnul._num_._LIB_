using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._num.bigint.be;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num.duo.divisible.op_
{
	public class Divide:duo.OpI
	{
		static public N Eval(duo.be.Divisible.Asserted a) {
			return new N( a.val.Item1.val / a.val.Item2.val);
		}



		public N eval(N a, N b)
		{
			return Eval(new be.Divisible.Asserted(a, b));
			throw new NotImplementedException();
		}
	}
}
