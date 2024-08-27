using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.re_.coprime_
{
	public  class _BrutalX
	{
		static public bool _IsCoprime_01natural(int x, int y) {
			return BigInteger.GreatestCommonDivisor(x, y) == 1;
		}
	}
}
