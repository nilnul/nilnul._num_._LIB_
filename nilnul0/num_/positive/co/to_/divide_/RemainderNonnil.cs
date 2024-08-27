using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.positive.co.op_.to_.divide_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _RemainderNonnilX
	{
		/// <summary>
		/// int is the computer execution unit if the computer is 32bit.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="keep"></param>
		/// <returns></returns>
		static public int _RemainderNonnil_assumePositives(in int x, in int y, out int keep) {
			var q = Math.DivRem(x, y, out keep);
			if (keep==0)
			{
				keep = y;
				return q - 1;

			}
			return q;
		}

		/// <summary>
		/// long is used for filesize. it's also the primary operand for 64bit computer.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="keep"></param>
		/// <returns></returns>
		static public long _RemainderNonnil_assumePositives(in long x, in long y, out long keep) {

			var q = Math.DivRem(x, y, out keep);
			// 99/3 = 33 ......0
			//100 /3=33 ......1

			if (keep==0)
			{
				keep = y;  ///3 
				return q - 1; //32

			}

			return q;
		}

		/// <summary>
		/// BigInteger is the builtin for big nums.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="keep"></param>
		/// <returns></returns>
		static public BigInteger _RemainderNonnil_assumePositives(in BigInteger x,in BigInteger y, out BigInteger keep) {
			var q = BigInteger.DivRem(x, y, out keep);
			if (keep==0)
			{
				keep = y;
				return q - 1;

			}
			return q;
		}

		static public Positive1 RemainderNonnil(in nilnul.num_.Positive1 x, in nilnul.num_.Positive1 y, out nilnul.num_.Positive1 keep) {
			var q = _RemainderNonnil_assumePositives(x.en,y.en,out BigInteger k);
			keep = new Positive1(k);
			return new Positive1( q );


		}

		static public Positive_struct RemainderNonnil(in nilnul.num_.Positive_struct x, in nilnul.num_.Positive_struct y, out nilnul.num_.Positive_struct keep) {
			var q = _RemainderNonnilX._RemainderNonnil_assumePositives( x.asInteger, y.asInteger,out BigInteger k);
			keep = new Positive_struct(k);
			return new Positive_struct( q );


		}


	}
}
