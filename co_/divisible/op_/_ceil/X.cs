using System;
using System.Net;
using nilnul.num.natural.relation;
using N = nilnul._num.bigint.be.Natural.Asserted;
using System.Numerics;

namespace nilnul.num.duo_.divisible.op_._ceil
{
	public static class X
	{
		

		public static BigInteger _Ceil(BigInteger _dividend_natural, BigInteger _divisor_positive)
		{
			BigInteger remainder;

			var t= BigInteger.DivRem(_dividend_natural, _divisor_positive, out remainder);
			if (remainder==0)
			{
				return t;

			}
			
				return t + 1;
			

			
			

			//throw new NotImplementedException();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="unit"></param>
		/// <returns></returns>
		public static  N  Ceil(this N a,
			nilnul._num.bigint.be.Positive.Asserted unit
			
		) {

			return new N(
				_Ceil(a.val,unit.val)	
			);
 

		
		}

		
		

	}
}
