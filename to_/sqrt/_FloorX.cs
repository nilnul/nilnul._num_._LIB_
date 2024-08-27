using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

using N = nilnul.num.natural.Natural_bigInteger;
using nilnul.num.natural;

namespace nilnul.num.to_.sqrt
{
	static public  class _FloorX
	{

		static public BigInteger _FloorOfSqrt_0positive(this BigInteger _positive)
		{
			//truncate half.

			var x = num_.positive.to_._LbX._Lb_0positive(_positive);// natural.op.LgX.Eval(_positive);

			var y = x / 2;   //floor of the number.


			var candidate = num.op_.binary_.pow_._BaseTwoX._Pow_0positive(_positive);// PowX.Pow(2, y);

			while (candidate * candidate <= _positive)
			{
				candidate++;

			}

			return candidate - 1;

		}
		static public BigInteger _FloorOfSqrt_0nonneg(this BigInteger _nonneg)
		{
			if (_nonneg==0)
			{
				return 0;
			}
			return _FloorOfSqrt_0positive(_nonneg);

		}



		static public Natural SqrtFloor(Natural n)
		{


			if (n == 0)
			{
				return new Natural(0);

			}
			return new natural.Count(_FloorOfSqrt_0positive(n.val));



		}




		static public Natural SqrtFloor(this uint i)
		{
			return SqrtFloor(new Natural(i));


		}

		static public Natural SqrtFloor(this long i)
		{
			return SqrtFloor(new Natural(i));


		}

		static public int Eval(this int i)
		{
			return SqrtFloor(new Natural(i)).ToInt();


		}
		static public Natural SqrtFloor(this BigInteger i)
		{
			return SqrtFloor(new Natural(i));


		}


		static public Count SqrtFloor(this Plural i)
		{
			return new Count(_FloorOfSqrt_0positive(i.val));


		}


	}
}
