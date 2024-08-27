using nilnul.num.natural.matrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.stream.fibonacci
{
	/// <summary>
	///  Fast doubling method. Faster than the matrix method.
	/// </summary>
	public class Doubling
	{
		

		public static BigInteger Item(BigInteger index)
		{

			if (index<2)
			{
				return index;


			}
			if (index==2)
			{
				return 1;
			}

			BigInteger remainder;

			BigInteger quotient = BigInteger.DivRem(index, 2, out remainder);

			var f_n = Item(quotient);
			var f_nPlus1 = Item(quotient + 1);

			if (remainder==0)
			{
				return f_n * (2*f_nPlus1-f_n);

			}
			else
			{
				return f_nPlus1 * f_nPlus1 + f_n * f_n;

			}



			



		}



	




	}
}
