using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num.co_.ge
{
	static public  class _CombinateX
	{
		static public BigInteger _assumeNumGe(BigInteger n_natural, BigInteger k_leN)
		{
			return

					nilnul.num.co_.ge._PermutateX._assumeNumGe(
						n_natural, k_leN
					)
				/
				nilnul.num.op_.unary_._FactorialX._ByLoop_assumeNat(
					k_leN
				)
		;
		}



		static public N Num(N total, N selected)
		{
			return new N(
				_assumeNumGe(total.val, selected.val)
			);
		}
	}
}
