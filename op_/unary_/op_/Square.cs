using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num.op_
{
	public class Square
	{
		static public BigInteger Eval(BigInteger x) { return x * x; }

		static public N Eval(N x) { return x * x; }
	}
}
