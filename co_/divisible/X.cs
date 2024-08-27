using System;
using System.Net;
using System.Numerics;

namespace nilnul.num.co_.divisible
{
	public static class _DivRemX
	{


		static public BigInteger _DivRem(
			
			this BigInteger _dividend_natural
			, 
			BigInteger _divisor_positive
				, 
			out BigInteger remainder
				)
		{

			return BigInteger.DivRem(_dividend_natural, _dividend_natural, out remainder);

			
		}


		static public Tuple<BigInteger, BigInteger> _DivRem__retTuple(
						this BigInteger _dividend_natural
			, 
			BigInteger _divisor_positive

			) {

			BigInteger remainder;

			var t= BigInteger.DivRem(_dividend_natural, _dividend_natural, out remainder);

			return new Tuple<BigInteger, BigInteger>(t, remainder);

		}

	}

	
}
