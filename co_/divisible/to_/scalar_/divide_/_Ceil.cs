using System;
using System.Net;
using nilnul.num.natural.relation;
using N = nilnul._num.bigint.be.Natural.Asserted;
using System.Numerics;

namespace nilnul.num.co_.divisible.op_.to_.scalar_.divide_
{
	public static class _CeilX
	{

		public static BigInteger _Ceil_divisorAssumePositive(BigInteger _dividend_natural, BigInteger _divisor_positive)
		{
			BigInteger remainder;

			var t = BigInteger.DivRem(_dividend_natural, _divisor_positive, out remainder);
			if (remainder == 0)
			{
				return t;

			}

			return t + 1;

		}

		public static long _Ceil_divisorAssumePositive(long _dividend_natural, long _divisor_positive)
		{

			var t = Math.DivRem(
				_dividend_natural
				,
				_divisor_positive
			, out long remainder
			);

			if (remainder == 0)
			{
				return t;

			}

			return t + 1;

		}

		public static int _Ceil_divisorAssumePositive(int _dividend_natural, int _divisor_positive)
		{

			var t = Math.DivRem(
				_dividend_natural
				,
				_divisor_positive
			, out int remainder
			);

			if (remainder == 0)
			{
				return t;

			}

			return t + 1;

		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="unit"></param>
		/// <returns></returns>
		public static N Ceil(this N a,
			nilnul._num.bigint.be.Positive.Asserted unit

		)
		{

			return new N(
				_Ceil_divisorAssumePositive(a.val, unit.val)
			);



		}




	}
}
