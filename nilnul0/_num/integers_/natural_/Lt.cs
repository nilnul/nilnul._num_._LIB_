using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integers_.natural_
{
	static public class _LtX
	{
		static public IEnumerable<int> _Ints_0natural(int _natural)
		{
			return Enumerable.Range(0, _natural);
		}

		static public IEnumerable<BigInteger> _Integers_0natural(BigInteger _natural)
		{

			BigInteger i = 0;
			do
			{
				yield return i;
			} while (++i < _natural);
		}
	}


}
