using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.op_
{
	/// <summary>
	/// given a set of n elements, B[n] is the number of different ways to partition that set.
	/// eg:
	///		0:1
	///		1:1
	///		2:2
	/// </summary>
	static public class _BellX
	{
		static public BigInteger _0natural(BigInteger n)
		{
			if (n == 0) { return 1; }

			n--;

			return nilnul.num.integers_.natural_._LeX._Integers_0natural(n).Select(
				k => nilnul.num.co_.ge._CombinateX._assumeNumGe(n, k) * _0natural(k)
			).Aggregate(
				(a, c) => a + c
			);
		}
	}
}
