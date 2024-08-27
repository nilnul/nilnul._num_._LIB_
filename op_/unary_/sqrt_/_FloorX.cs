using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

using N = nilnul.num.natural.Natural_bigInteger;
using  nilnul.num.natural;

namespace nilnul.num.op_.unary_.sqrt_
{
	static public  class _FloorX
	{

		/// <summary>
		/// of 2^31-1
		/// </summary>
		/// <returns></returns>
		static public int _SqrtFloorOfIntMax()
		{
			///in an open interval.
			var lower = 1 << 15;
			var upper = 1 << 16;

			while (lower<upper-1)
			{
				var mid = ( lower+ upper) / 2 ;

				var midAsLong = (long)mid;
				var midSq = midAsLong*midAsLong;

				if (midSq==int.MaxValue)
				{
					return mid;

				}
				if (midSq<int.MaxValue)
				{
					lower = mid;

				}
				else
				{
					upper = mid;
				}


			}

			return lower;


		}

		static public readonly int SqrtFloorOfIntMax = _SqrtFloorOfIntMax();
		static public readonly int SqrtCeilOfIntMax = SqrtFloorOfIntMax+1;

		static public int _SqrtFloor_0nonneg(this int _nonneg)
		{
			switch (_nonneg)
			{
				case 0:
					return 0;
				case 1:
					return 1;
				case 2:
					return 1;
				case 3:
					return 1;

				case 4:
					return 2;
				case 5:
					return 2;

				case int.MaxValue:
					return SqrtFloorOfIntMax;
			
			}

			var ceil = SqrtCeilOfIntMax;

			///in an open interval.
			var lower = 2;

			var half=_nonneg/2 ;

			var upper = half > ceil ? ceil : half;


			while (lower<upper-1) //tgts are open interval.
			{
				var mid = ( lower+ upper) / 2 ; /// even upper is gt IntMaxSqrtCeil, mid is still lt IntMaxSqrtCeil as lower is lt IntMaxSqrtCeil

				var midSq = mid * mid;  // will midSq is greater than intMax? that means mid gt IntMaxSqrtFloor.

				if (midSq==_nonneg)
				{
					return mid;

				}
				if (midSq<_nonneg)
				{
					lower = mid;

				}
				else
				{
					upper = mid;
				}


			}

			return lower;
		




		}

	


	}
}
