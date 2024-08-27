using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._num.bigint.be;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num.duo.divisible.op
{
	[Obsolete()]
	public class Divide
	{
		static public Duo Eval(duo.be.Divisible.Asserted a) {
			BigInteger remainder;
			var q= BigInteger.DivRem(a.val.Item1.val, a.val.Item2.val,out remainder);
			return new Duo(q, remainder);
		}



		
	}
}
