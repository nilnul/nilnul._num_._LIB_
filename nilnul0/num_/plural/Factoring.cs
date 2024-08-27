using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using nilnul.num.natural.collection;
using nilnul.num.prime;
using P = nilnul.num_.plural_.Prime; 

namespace nilnul.num_.plural
{
	


	static public  class _FactorX
	{


	

		public static num_.plural_.prime.Bag _Bag_assumePlural_byTailInt(BigInteger _plural)
		{
			num_.plural_.prime.Bag bag = new num_.plural_.prime.Bag();
			var primeHead = _factor._LeastFactorX._Eval_tailInt(_plural);

			bag.add(new P(primeHead.First()));

			if (primeHead.Count == 1)
			{
				return bag;
			}
			else {

				return num_.plural_.prime.bag.op_.binary_.Union.Op(
					bag
					,

					_Bag_assumePlural_byTailInt(
						primeHead.Last()
					)
				);
			}

		}
		public static num_.plural_.prime.Bag _Bag_assumePlural(BigInteger _plural)
		{
			var primeHead = _factor._LeastFactorX._Eval_retBagTail(_plural);
			primeHead.Item2.add( new P( primeHead.Item1));
			return primeHead.Item2;
		}


	}
}
