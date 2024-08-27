using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace nilnul.num_.positive.to_
{
	/// <summary>
	/// find x such that [2^x, 2^(x+1)] has the given tgt;
	/// the result is a nonneg num;
	/// </summary>
	static public  class _LbX
	{


		/// <inheritdoc cref="_LbX"/>
		/// <remarks>
		/// eg:
		///		[2^3, 2^4) has 8,9,...,15. So lb(8) =3, lb(15) =3
		///		[2^0,2^1) has 1. so lb(1)=0
		///		
		/// </remarks>
		/// <param name="x"></param>
		/// <returns></returns>
		static public BigInteger _Lb_0positive(this BigInteger x) {
			return _lb.algo_._ByOctetX._FloorLb_0positive(x);
		}


		public static BigInteger Lb(this num_.ref_.vowless_.Positive i)
		{
			return _Lb_0positive(i.eeByRef);
		}
		public static BigInteger Lb(this BigInteger i)
		{
			return Lb(
				 num_.ref_.vowless_.Positive.Of(i)
			);
		}




	}
}
