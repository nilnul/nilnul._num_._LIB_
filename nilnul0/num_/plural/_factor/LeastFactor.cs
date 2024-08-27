using nilnul.num.prime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.plural._factor
{
	/// <summary>
	/// 
	/// </summary>
	/// 
	


	static public class _LeastFactorX
	{


		



		static public List<BigInteger> _Eval_tailInt(BigInteger _plural) {

			var result = new List<BigInteger>();


			foreach (var item in /*num.natural.prime.collection.AutoGrowMem*/nilnul.num_.plural_.prime.set_.db_.ef.AutoGrowMem.SequenceUpTo_inBigInteger__positive(
				num.natural.SqrtFloorX._SqrtFloor(_plural)
			))
			{
				BigInteger remainder;

				var quotient = BigInteger.DivRem(_plural, item, out remainder);

				if (remainder == 0)
				{
					result.Add(item);
					result.Add(quotient);
					return result;
				}
			}
			result.Add(_plural);
			return result;
		}

		static public Tuple<BigInteger , num_.plural_.prime.Bag> _Eval_retBagTail(BigInteger _plural) {

			var primeHeaded = _Eval_tailInt(_plural);
			if (primeHeaded.Count==1)
			{
				return new Tuple<BigInteger, num_.plural_.prime.Bag>(primeHeaded.First(), new num_.plural_.prime.Bag());
			}

			return new Tuple<BigInteger, num_.plural_.prime.Bag>(
				primeHeaded.First()
				,

				plural._FactorX._Bag_assumePlural_byTailInt(primeHeaded.Last())

			);
		}

	}
}
