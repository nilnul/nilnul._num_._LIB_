using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using nilnul.num.natural;

namespace nilnul.num.op_.unary_
{
	[Obsolete(nameof(num_.plural.duo_.positive._lg.algo_._ByTwoFoldSearchX._FloorLg_0plural_1positive))]
	public static class LgX
	{

		static public Natural Lb(Count goal) {
			return Lg(2, goal);

		
		}

		public static Natural Lb(BigInteger goal) {
			return Lb(new Count(goal));
		
		}

		static public Natural Lg(int @base,Count goal) {
			return Lg(new Count(@base),goal);
		
		}

		

		/// <summary>
		/// 
		/// </summary>
		/// <param name="goal"></param>
		/// <returns></returns>
		/// <remarks>
		/// Will accrue the 2's power
		/// </remarks>

		public static Natural Lg(Count @base, Count goal)
		{
			


			//exp will be the upper bound. exp-1 will be the lower bound. the unknown is in (2^exp-1,2^exp]

			return new Natural(_byRecurRecon(2,goal.val));


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

			return num_.plural.duo_.positive._lg.algo_._ByTwoFoldSearchX._FloorLg_0plural_1positive(base_positive,goal_positive);



		}

		[Obsolete(nameof(num_.positive.to_._lb.algo_._ByDblX))]
		public static int Log2Floor(this BigInteger i)
		{
	
			return num_.positive.to_._lb.algo_._ByDblX.FloorLb(i);

			


		}



	}
}
