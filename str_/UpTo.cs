using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;


namespace nilnul.num.str_
{
	static public class _UpTo
	{
		static public IEnumerable<BigInteger> _Bigints(BigInteger n) {
			for (BigInteger	i = 0; i <= n; i++)
			{
				yield return i;
			}
		}
		static public IEnumerable<int> _Ints(int n) {
			for (int	i = 0; i <= n; i++)
			{
				yield return i;
			}
		}


	}
}
