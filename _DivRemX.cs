using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num
{
	static public class _Div4RemPositiveX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dividend_positive"></param>
		/// <param name="divisor_positive"></param>
		/// <param name="remainder">
		///		always positive, up to divisor
		/// </param>
		/// <returns>natural, may be zero</returns>
		static public BigInteger _Div4RemPositive(BigInteger dividend_positive, BigInteger divisor_positive, out BigInteger remainder) {


			var quotient=BigInteger.DivRem(dividend_positive, divisor_positive, out remainder);

			if (remainder==0)
			{
				quotient--;

				remainder = divisor_positive;

			}

			return quotient;
		}
	}
}
