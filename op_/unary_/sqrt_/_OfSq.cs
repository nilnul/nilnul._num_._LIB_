using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

using N = nilnul.num.natural.Natural_bigInteger;
using  nilnul.num.natural;

namespace nilnul.num.op_.unary_.sqrt_
{
	/// <summary>
	/// the input is a perfect square
	/// </summary>
	static public  class _OfSqX
	{


		/// <summary>
		/// 
		/// </summary>
		/// <param name="_sq">perfect square; eg:4, excluding:5</param>
		/// <returns></returns>

		static public int _Sqrt_0sq(this int _sq)
		{
			var sqrtFloorOfMax = _FloorX.SqrtFloorOfIntMax;

			var lower = 0;

			var upper = _sq > sqrtFloorOfMax ? sqrtFloorOfMax : _sq; //close interval.


			while (lower<upper) 
			{
				var mid = ( lower+ upper) / 2 ;

				var midSq = mid * mid;

				if (midSq==_sq)
				{
					return mid;
				}

				if (midSq<_sq)
				{
					lower = mid+1; // cuz the input is perfect squre, 

				}
				else
				{
					upper = mid-1;
				}


			}

			return lower;
		




		}

	


	}
}
