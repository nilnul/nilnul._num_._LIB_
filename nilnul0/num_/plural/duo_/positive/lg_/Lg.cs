using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace nilnul.num.duo_.pluralPositive.cast_
{
	[Obsolete(nameof(nilnul.num_.plural.duo_.positive._lg.algo_._ByTwoFoldSearchX))]
	public class Lg:CastI<nilnul.num.Range>
	{
		public Range cast(PluralPositive input)
		{
			return _cast(input.Item1,input.Item2);
			throw new NotImplementedException();
		}

		public Range cast(nilnul.num_.Plural radic, nilnul.num_.Positive positive) {
			return _cast(radic, positive);
		}

		public  nilnul.num.Range _cast(
			BigInteger _base_plural, BigInteger _goal_positive
			)
		{

			BigInteger lowerIndex = 0;
			BigInteger base_lowerIndexed = 1;

			//search for upperbound +1, or +0



			BigInteger forwardIndex;
			BigInteger forwardExponent;
			BigInteger goal2recon;	//reconnaissance plane

			do
			{
				forwardIndex = 1;
				forwardExponent = _base_plural;	//@base_positive^forwardIndex;
				goal2recon = base_lowerIndexed * forwardExponent;	//

				while (goal2recon <= _goal_positive)
				{

					//update index
					lowerIndex = lowerIndex + forwardIndex;
					base_lowerIndexed = goal2recon;

					//update forward
					forwardIndex *= 2;
					forwardExponent *= forwardExponent;


					//update recon
					goal2recon = base_lowerIndexed * forwardExponent;

				}//overreach, now backtrack

			}
			while (forwardIndex != 1);


			if (base_lowerIndexed==_goal_positive)
			{
				return  nilnul.num.Range.CreateClose(new nilnul.Num(lowerIndex), new nilnul.Num( lowerIndex));
			}
			else
			{
				return  nilnul.num.Range.CreateClose(
					(nilnul.Num)lowerIndex, (nilnul.Num)(lowerIndex + 1)
				);
			}

		}


		static public Lg Singleton
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Lg>.Unison;
			}
		}

		//[Obsolete()]
		//static public readonly Lg Singleton = nilnul.obj.SingletonByDefault<Lg>.Instance;



	}
}
