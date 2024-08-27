using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using nilnul.num.natural;
using System.Collections;

namespace nilnul.num_.positive.to_._lb.algo_
{
	static public class _ByOctetX
	{
		/// In .Net 5 this is now built-in...
		/// int log2 = myBigInt.GetBitLength()
		/// <summary>
		/// </summary>
		/// <param name="n"></param>
		/// <returns></returns>
		public static BigInteger _FloorLb_0positive(this BigInteger _positive)
		{
			///note a all nil array might be appended to avoid being misinterpreted as negative number;
			var array = _positive.ToByteArray();
			var bytesHighIndex = array.Length;

			var t = array[--bytesHighIndex];
			if (t == 0) /// a sign array;
			{
				t = array[--bytesHighIndex];
			}

			int topbit = (bitly_._ByLoopX._FloorLb_0positive(t) + bytesHighIndex * 8);
			return topbit;
		}

	}
}