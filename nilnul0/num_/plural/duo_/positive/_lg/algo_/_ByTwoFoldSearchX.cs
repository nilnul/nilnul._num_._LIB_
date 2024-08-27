using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace nilnul.num_.plural.duo_.positive._lg.algo_
{
	/// <summary>
	/// search one step, another 2 step, another 4 step, another 8 step, another 2^n step; and then backtrack, search between 2^n, 2^(n-1);
	/// </summary>
	/// <remarks>
	/// imaging we drive a car; to reach a target as soon as possible, we need first accelerate, and when overtaking it, backtrack; 
	/// </remarks>
	/// alias:
	///		加速梯度下降
	///			accelerated (sub)gradient algorithms (ASGA)
	static public  class _ByTwoFoldSearchX
	{
	

		/// <summary>
		/// [x,x+1), where base^(x+1)> given tgt, and base^x &le; given tgt;
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
		public static BigInteger _FloorLg_0plural_1positive(
			BigInteger @base_positive
			,
			BigInteger goal_positive
		) {
			
			BigInteger indic = 0; //the x in b^x; this is what to be returned;
			BigInteger accumulated=1; /// 2^index



			BigInteger ponentOf2_asIndicOfForward;	//x in forward=factor^(2^x)
			BigInteger powForward;
			BigInteger forwardIndic;

			BigInteger recon;  //lower Border


			do
			{
				//init forward
				ponentOf2_asIndicOfForward = 0;
				forwardIndic = 1; // indicIncrement =1
				powForward =@base_positive; // eg:9^1=9, powIncrease=9

				// init recon
				recon = accumulated*powForward; //totalPow
		
				while (recon <= goal_positive)
				{
					//update index
					indic +=  forwardIndic;
					accumulated = recon; //next lowerBorde of Pow


					//update forward

					ponentOf2_asIndicOfForward = ponentOf2_asIndicOfForward + 1;
					forwardIndic *= 2;
					powForward *= powForward;

					//update recon
					recon = accumulated * powForward; //next upperBound
				}//overreach, now backtrack


			} while (ponentOf2_asIndicOfForward != 0); // we need to shrink the range's width to one;
			

			return indic;

		}

		static public BigInteger Lg(
			this num_.ref_.vowless_.Plural _basic_plural
			,
			num_.ref_.vowless_.Positive _tgt_positive
		)
		{
			return _FloorLg_0plural_1positive(
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
