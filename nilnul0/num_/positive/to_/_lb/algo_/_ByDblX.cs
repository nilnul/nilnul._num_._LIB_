using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using nilnul.num.natural;

namespace nilnul.num_.positive.to_._lb.algo_
{
	static public class _ByDblX
	{
		[Obsolete()]
		public static int _FloorLb_0positive(this BigInteger i)
		{
			int x = (int)(Math.Floor(BigInteger.Log(i, 2)));

			//search around x
			//decide the direction
			var y = BigInteger.Pow(2, x);
			while (y < i)
			{
				x++;
				y = BigInteger.Pow(2, x);

				if (y > i) { return x - 1; }
			}

			while (y > i)
			{
				x--;
				y = BigInteger.Pow(2, x);
				if (y < i) { return x; }
			}
			return x;
		}
		public static int FloorLb(this num_.ref_.vowless_.Positive i)
		{
			return _FloorLb_0positive(i.eeByRef);
		}
		public static int FloorLb(this BigInteger i)
		{
			return FloorLb(
				 num_.ref_.vowless_.Positive.Of(i)
			);
		}


	}
}