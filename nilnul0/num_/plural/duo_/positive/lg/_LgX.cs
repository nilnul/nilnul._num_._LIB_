using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.plural.duo_.positive
{
	/// <summary>
	/// search x such that [b^x, b^(x+1) has the given target;
	/// where b is plural, x is positive;
	/// </summary>
	/// <seealso cref="num."/>
	static public class _LgX
	{
		static public BigInteger _Lg_0plural_1positive(
			this BigInteger _basic_plural
			,
			BigInteger _tgt_positive
		) {
			//if (_tgt_positive==1)
			//{
			//	return 0;
			//}
			// lg(b,x) = lb(x) /lb(b)
			var lbTgt = num_.positive.to_._LbX._Lb_0positive(_tgt_positive);	//[0,
			var lbBasic = num_.positive.to_._LbX._Lb_0positive(_basic_plural);	// [1,

			var lower = lbTgt / ( lbBasic+1); /// open border; but we need a closed lower: increment this might overkill; So let's take this as the closed to ensure the clopen interval still has tgt's src;
			var upper = (lbTgt + 1) / lbBasic +1; // without plusing one, this might be closed border due to rounding; /// imagine that basic is very big;

			///binary search;

			while (upper-lower>1)
			{
				var mid = (lower + upper) / 2;

				var midPow = nilnul.num.op_.binary_._PowX._Op_basePlural_indexPositive(
					_basic_plural, mid
				);
				if (midPow >_tgt_positive)
				{
					upper = mid;
				}
				else if (midPow==_tgt_positive)
				{
					return mid;
				}
				else
				{
					lower= mid;

				}
			}
			return lower;



		}
		static public BigInteger Lg(
			this num_.ref_.vowless_.Plural _basic_plural
			,
			num_.ref_.vowless_.Positive _tgt_positive
		)
		{
			return _Lg_0plural_1positive(
				_basic_plural.eeByRef
				,
				_tgt_positive.eeByRef
			);
		 }

		static public BigInteger Lg(
			this BigInteger _basic_plural
			,
			BigInteger _tgt_positive
		)
		{
			return Lg(
				 ref_.vowless_.Plural.Of(_basic_plural)
				,
				ref_.vowless_.Positive.Of(_tgt_positive)
			);
		 }

	}
}
