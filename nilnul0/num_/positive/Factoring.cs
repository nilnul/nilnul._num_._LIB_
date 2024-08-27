using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using nilnul.num.natural.collection;
using nilnul.num.prime;
using P = nilnul.num_.plural_.Prime;

namespace nilnul.num_.positive
{



	/// <summary>
	/// factorize a positive num into a bag of primes, where bagOfPrimes is defined elsewhere.
	/// </summary>
	public  class Factor
	{
		public static num_.plural_.prime.Bag _Eval(BigInteger _positive) {
			return _Eval_tailBag(_positive);
		}



		public static num_.plural_.prime.Bag _Eval_tailInt(BigInteger _positive)
		{
			if (_positive==1)
			{
				return new num_.plural_.prime. Bag();
			}
			return num_.plural._FactorX._Bag_assumePlural_byTailInt(_positive);

		}

		public static num_.plural_.prime.Bag _Eval_tailBag(BigInteger _positive)
		{
			if (_positive==1)
			{
				return new num_.plural_.prime. Bag();
			}
			return num_.plural._FactorX._Bag_assumePlural(_positive);

		}


	}


}
