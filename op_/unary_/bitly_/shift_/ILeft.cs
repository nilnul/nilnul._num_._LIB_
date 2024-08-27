using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.op_.unary_.bitly_.shift_
{
	static public class _LeftX
	{
		/// <summary>
		///	x => 2^x
		/// eg:
		///		0:1  ,that is: 2^0=1
		///		1:2
		/// </summary>
		/// <remarks>
		/// another way to express 2^x;
		/// </remarks>
		/// <param name="x"></param>
		/// <returns></returns>
		/// alias:
		///		fold,
		///			, initially, there is an obj; if we fold it zero times, that is if we don't fold, it's one; if we fold it once, we get two; if we fold it twice, we get four;
		///		twofold
		///		,
		///		shift
		///			,left shift, not right shift which is called unshift.
		static public int ShiftLeft(int x) {

			var r = 1 << x; //no overflow but a negative number. checked will not throw;

			if (r<0) // when x is 31, the result is "1000..."
			{
				throw new OverflowException($"{x} is {31}, making the result negative;");
			}

			return r; 
		}
	}
}
