using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using N = nilnul._num.bigint.be.Natural.Asserted;


namespace nilnul.num.mono.op_
{
	public class Gcd
		: nilnul.OpI<N>
	{
		public N eval(N arg)
		{
			return arg;
			throw new NotImplementedException();
		}
	}
}
