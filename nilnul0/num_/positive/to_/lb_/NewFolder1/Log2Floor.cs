using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace nilnul.num.natural
{
	[Obsolete(nameof(num_.plural.duo_.positive._lg.algo_._ByTwoFoldSearchX._FloorLg_0plural_1positive))]
	public static class Log2FloorX
	{
	


		/// <summary>
		/// 
		/// </summary>
		/// <param name="goal"></param>
		/// <returns></returns>
		/// <remarks>
		/// Will accrue the 2's power
		/// </remarks>

		public static Natural Log2Floor2_byRecurTry(this PositiveNatural2 goal)
		{
			


			//exp will be the upper bound. exp-1 will be the lower bound. the unknown is in (2^exp-1,2^exp]

			return new Natural(_byRecurRecon(2,goal.val.val));


		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="accumulated"></param>
		/// <param name="goal">
		/// 
		/// </param>
		/// <param name="factor"></param>
		/// <returns>
		/// get an index
		/// [0,...)
		/// </returns>
		/// <remarks>
		/// get an x such that accumulated*factor^(2^x) &lt; goal &le; accumlated*factor^(2^(x+1)).
		/// 
		/// increase the accumulated one time and again.
		/// </remarks>
		///
		[Obsolete(nameof(num_.plural.duo_.positive._lg.algo_._ByTwoFoldSearchX._FloorLg_0plural_1positive))]
		private static BigInteger _byRecurRecon(BigInteger @base_positive,BigInteger goal_positive ) {

			return num_.plural.duo_.positive._lg.algo_._ByTwoFoldSearchX._FloorLg_0plural_1positive(
				base_positive,goal_positive
			);
	

		}

		[Obsolete(nameof(num_.positive.to_._lb.algo_._ByDblX._FloorLb_0positive))]
		public static int Log2Floor(this BigInteger i)
		{
			if (i<=0)
			{
				throw new ArgumentOutOfRangeException($"{i} must be positive to be Lb-ed;");
			}
			return num_.positive.to_._lb.algo_._ByDblX._FloorLb_0positive(i);

			



		}



	}
}
