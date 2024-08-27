using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.of_.unary_
{
	/// <summary>
	/// <seealso cref="op_.binary_.pow_._BaseTwoX"/>
	/// input:x
	///	result: 2^x
	///	x=>2^x
	/// </summary>
	/// <remarks>
	/// x=> 1 leftShit  x
	/// </remarks>
	/// alias:
	///		bitwise shift left of 1.
	static public class _Ponent8twoX
	{
		static public BigInteger _Pow_0positive(BigInteger index_natural)
		{

			BigInteger remainder;
			var half = BigInteger.DivRem(index_natural, 2, out remainder);

			var halfPow = _Pow_indexAssumeNatural(half);
			//var halfPowSquared = halfPow * halfPow;
			return remainder == 0 ? halfPow * halfPow : halfPow * halfPow * 2;
		}
		static public BigInteger _Pow_indexAssumeNatural(BigInteger index_natural)
		{
			if (index_natural == 0)
			{
				return 1;

			}
			return _Pow_0positive(index_natural);

			BigInteger remainder;
			var half = BigInteger.DivRem(index_natural, 2, out remainder);

			var halfPow = _Pow_indexAssumeNatural(half);
			//var halfPowSquared = halfPow * halfPow;
			return remainder == 0 ? halfPow * halfPow : halfPow * halfPow * 2;
		}


		static public int _Pow_indexAssumeNatural(int index_natural)
		{
			if (index_natural == 0)
			{
				return 1;

			}

			//BigInteger remainder;
			var half = Math.DivRem(index_natural, 2, out var remainder);

			var halfPow = _Pow_indexAssumeNatural(half);
			//var halfPowSquared = halfPow * halfPow;
			return remainder == 0 ? halfPow * halfPow : halfPow * halfPow * 2;
		}

		static public long _Pow_indexAssumeNatural(long index_natural)
		{
			if (index_natural == 0)
			{
				return 1;

			}

			//BigInteger remainder;
			var half = Math.DivRem(index_natural, 2, out var remainder);

			var halfPow = _Pow_indexAssumeNatural(half);
			//var halfPowSquared = halfPow * halfPow;
			return remainder == 0 ? halfPow * halfPow : halfPow * halfPow * 2;
		}

		static public int Op(int exp)
		{
			return 1 << exp;
		}


	}
}
