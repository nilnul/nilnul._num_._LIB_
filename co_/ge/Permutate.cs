using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul._num.bigint.be;
using nilnul.num.duo.op_._permutate;
using N = nilnul._num.bigint.be.Natural.Asserted;


namespace nilnul.num.co_.ge
{
	static public class _PermutateX
	{
		
		
		public static BigInteger _assumeNumGe(this BigInteger _total_natural, BigInteger _selected_natural_leTotal)
		{

			BigInteger r = 1;
			for (BigInteger i = _total_natural; i > _total_natural- _selected_natural_leTotal; i--)
			{
				r *= i;
			}
			return r;


		}

		public static BigInteger _assumeNum(this BigInteger _total_natural)
		{
			return _assumeNumGe(_total_natural, _total_natural);
		}

		static public N Num(N total, N selected)
		{
			return new N(
				_assumeNumGe(total.val, selected.val)
			);
		}

	}

}
