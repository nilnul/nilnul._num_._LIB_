using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.natural.stream
{
	[Obsolete()]
	public  class Odd
	{
		static public BigInteger GetItem(BigInteger x) {
			return 2 * x + 1;

		}
		static public BigInteger GetItem(int x) {
			return 2 * x + 1;

		}
	}
}
