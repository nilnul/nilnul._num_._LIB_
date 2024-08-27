using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using N = nilnul.Num;

namespace nilnul.num.op_.unary_
{
	 public class Square
	{
		static public BigInteger Bigint(BigInteger x) { return x * x; }

		static public N Num(N x) { return x * x; }
	}
}
