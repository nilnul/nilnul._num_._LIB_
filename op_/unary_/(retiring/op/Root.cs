using nilnul.num.natural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.op
{
	public partial class Root
	{
		public static Natural Eval(Natural @base, Count indexDenominator)
		{
			if (@base == 0)
			{
				return (Natural)0;

			}

			return new Natural( _Eval(@base.val, indexDenominator.val));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="base_positive">count (>=1)</param>
		/// <param name="indexDenominator"> count(>=1) </param>
		/// <returns></returns>
		/// <remarks>
		/// not using Newton Method for its complexity
		/// using binary search instead.
		/// </remarks>
		public  static BigInteger _Eval(BigInteger base_positive, BigInteger radical_positive)
		{


			var right = 1 + (base_positive - 1) / radical_positive+1;		//+1 for the ceiling operation to ensuer rightPow>@base.

			BigInteger left = 1;
			BigInteger span = right - left;

			while (span > 1)
			{
				BigInteger middle = left + span / 2; // if right = left +2+n, where n>=0, then middle = left+1+n/2m which is greater than left, and less than right.

				var middlePow = PowX.Pow(base_positive, middle);

				if (middlePow > base_positive)
				{
					right = middle;

				}
				else

				if (middlePow < base_positive)
				{
						left = middle;

				}
				else
				{
						return middle;
				}

				span = right - left;

			}

			return left;


		}

		public  static BigInteger _Eval_Ceil_positive(BigInteger base_positive, BigInteger radical_positive)
		{


			var right = 1 + (base_positive - 1) / radical_positive+1;		//+1 for the ceiling operation to ensuer rightPow>@base.

			BigInteger left = 1;
			BigInteger span = right - left;

			while (span > 1)
			{
				BigInteger middle = left + span / 2; // if right = left +2+n, where n>=0, then middle = left+1+n/2m which is greater than left, and less than right.

				var middlePow = PowX.Pow(middle, radical_positive);

				if (middlePow > base_positive)
				{
					right = middle;

				}
				else

				if (middlePow < base_positive)
				{
						left = middle;

				}
				else
				{
						return middle;
				}

				span = right - left;

			}

			return right;


		}

		public  static BigInteger _Eval_natural(BigInteger base_natural, BigInteger radical_positive)
		{


			return base_natural == 0 ? 0 : _Eval(base_natural, radical_positive);


		}
		public  static BigInteger _Eval_ceil_natural(BigInteger base_natural, BigInteger radical_positive)
		{


			return base_natural == 0 ? 0 : _Eval_Ceil_positive(base_natural, radical_positive);


		}

	}
}
