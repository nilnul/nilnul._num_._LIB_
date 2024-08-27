using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using nilnul.num.natural;
using System.Runtime.CompilerServices;

namespace nilnul.num_.positive.to_._lb.algo_.bitly_
{
	static public class _ByLoopX
	{
		/// In .Net 5 this is now built-in...
		/// int log2 = myBigInt.GetBitLength()
		/// <summary>
		/// </summary>
		/// <param name="n"></param>
		/// <returns></returns>
		public static BigInteger _FloorLb_0positive(this BigInteger n)
		{
			BigInteger count = 0;
			do
			{
				n >>= 1;
				count++;

			} while (n > 0);

			

			return count-1;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int _FloorLb_0positive(this byte _positive)
		{
			var r = 0;
			do
			{
				_positive >>= 1;
				r++;
			} while (_positive > 0);

			return r-1;
		}

	}
}