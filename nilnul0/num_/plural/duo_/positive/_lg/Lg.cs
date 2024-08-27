using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace nilnul.num.natural.op
{
	[Obsolete(nameof(nilnul.num_.plural.duo_.positive._lg.algo_._ByTwoFoldSearchX))]
	public static class LgX
	{

		

		static public Natural Eval(int @base,Count goal) {
			return Eval(new Count(@base),goal);
		
		}

		
		static public Natural Eval(Count goal) {
			return Eval(2, goal);

		
		}

		public static Natural Eval(BigInteger goal) {


			return Eval(new Count(goal));
		
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="goal"></param>
		/// <returns></returns>
		/// <remarks>
		/// Will accrue the 2's power
		/// </remarks>

		public static Natural Eval(Count @base, Count goal)
		{
			


			//exp will be the upper bound. exp-1 will be the lower bound. the unknown is in (2^exp-1,2^exp]

			return new Natural(_Eval_retFloor(2,goal.val));


		}

		static public BigInteger _Eval_base2_retFloor(BigInteger positive) {
			return _Eval_retFloor(2, positive);

		}

		static public Tuple<BigInteger,BigInteger> _Eval_base2_retInterval(BigInteger positive) {
			return _Eval_retInterval(2, positive);

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
		public static BigInteger _Eval_retFloor(BigInteger base_plural,BigInteger goal_positive ) {


			return _Eval_retInterval(base_plural, goal_positive).Item1;

			

			

		}


		public static Tuple<BigInteger,BigInteger> _Eval_retInterval(BigInteger base_plural, BigInteger goal_positive)
		{

			BigInteger index = 0;
			BigInteger base_indexed = 1;

			//search for upperbound +1, or +0

			bool exactly = true;


			BigInteger forwardIndex=1;
			BigInteger forward=base_plural;
			BigInteger goal2recon=base_indexed*forward;	//reconnaissance plane

			do
			{
				forwardIndex = 1;
				forward = base_plural;	//@base_positive^forwardIndex;
				goal2recon = base_indexed * forward;	//

				while (goal2recon <= goal_positive)
				{

					//update index
					index = index + forwardIndex;
					base_indexed = goal2recon;

					//update forward
					forwardIndex *= 2;
					forward *= forward;


					//update recon
					goal2recon = base_indexed * forward;

				}//overreach, now backtrack

			}
			while (forwardIndex != 1);


			if (base_indexed==goal_positive)
			{
				return new Tuple<BigInteger, BigInteger>(index, index);
			}
			else
			{
				return new Tuple<BigInteger, BigInteger>(index, index + 1);
			}

		}



	}
}
