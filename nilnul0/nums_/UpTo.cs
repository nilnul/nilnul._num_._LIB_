using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;


namespace nilnul.nums_
{
	static public class _UpTo
	{
		static public IEnumerable<BigInteger> _Bigints(BigInteger n) {
			for (BigInteger	i = 0; i <= n; i++)
			{
				yield return i;
			}
		}

		static public IEnumerable<nilnul.Num1> _Nums_assumeNonneg(BigInteger n) {
			return _Bigints(n).Select(x => new nilnul.Num1(x));
		}

	}
}
