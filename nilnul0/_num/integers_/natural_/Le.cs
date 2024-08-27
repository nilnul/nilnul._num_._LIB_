using System.Collections.Generic;
using System.Numerics;

namespace nilnul.num.integers_.natural_
{
	static public class _LeX
	{
		static public IEnumerable<int> _Ints_0natural(int _natural)
		{
			var i = 0;
			do
			{
				yield return i;
			} while (++i <= _natural);

		}
		static public IEnumerable<BigInteger> _Integers_0natural(BigInteger _natural)
		{

			BigInteger i = 0;
			do
			{
				yield return i;

			} while (++i <= _natural);
		}
	}


}
