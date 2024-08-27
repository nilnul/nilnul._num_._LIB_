using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.op_.binary_.pow_
{
	static public  class _BaseTwoX
	{
		static public BigInteger _Pow_0positive(BigInteger index_natural) {

			BigInteger remainder;
			var half = BigInteger.DivRem(index_natural, 2, out remainder);

			var halfPow = _Pow_indexAssumeNatural( half);
			//var halfPowSquared = halfPow * halfPow;
			return remainder == 0 ? halfPow * halfPow : halfPow * halfPow * 2;
		}
		static public BigInteger _Pow_indexAssumeNatural(BigInteger index_natural) {
			if (index_natural == 0)
			{
				return 1;

			}
			return _Pow_0positive(index_natural);

			BigInteger remainder;
			var half = BigInteger.DivRem(index_natural, 2, out remainder);

			var halfPow = _Pow_indexAssumeNatural( half);
			//var halfPowSquared = halfPow * halfPow;
			return remainder == 0 ? halfPow * halfPow : halfPow * halfPow * 2;
		}


		static public int _Pow_indexAssumeNatural(int index_natural) {
			if (index_natural == 0)
			{
				return 1;

			}

			//BigInteger remainder;
			var half = Math.DivRem(index_natural, 2, out var remainder);

			var halfPow = _Pow_indexAssumeNatural( half);
			//var halfPowSquared = halfPow * halfPow;
			return remainder == 0 ? halfPow * halfPow : halfPow * halfPow * 2;
		}

		static public long _Pow_indexAssumeNatural(long index_natural) {
			if (index_natural == 0)
			{
				return 1;

			}

			//BigInteger remainder;
			var half = Math.DivRem(index_natural, 2, out var remainder);

			var halfPow = _Pow_indexAssumeNatural( half);
			//var halfPowSquared = halfPow * halfPow;
			return remainder == 0 ? halfPow * halfPow : halfPow * halfPow * 2;
		}

		static public int Op(int exp) {
			return 1 << exp;
		}


	}
}
