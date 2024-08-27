using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

using N = nilnul.num.natural.Natural_bigInteger;


namespace nilnul.num.natural.prime
{
	[Obsolete()]
	public partial class Factoring
	{

		//static void Main(string[] args)
		//{
		//	var d = Eval(60);
			
		//}


		/// <summary>
		/// u must be greater than 1.
		/// </summary>
		/// <param name="u"></param>
		/// <returns></returns>

		private static Dictionary<BigInteger, long> _EvalRecur(BigInteger u) {

			Dictionary<BigInteger, long> composition= new Dictionary<BigInteger, long>();

			var r = nilnul.num.natural.op.unary.SqrtFloorX.SqrtFloor(u);

			BigInteger remainder;

			bool isPrime = true;
			
			foreach (var item in collection.AutoGrowMem.SequenceUpTo_inBigInteger__positive(r ).OrderBy(ccc => ccc))
			{
				//divide the number

				var t = u / item;
				var quotient = BigInteger.DivRem(u, item, out  remainder);

				if (remainder == 0)
				{

					composition= _EvalRecur(quotient);
		
					
					if (composition.ContainsKey((item)))
					{
						composition[item]++;
					}
					else
					{
						composition.Add(item, 1);
					}
					isPrime = false;
					break;
				}

			}

			if (isPrime)
			{
				composition.Add(u, 1);
				
			}
			return composition;
		
		}

		public static Dictionary<BigInteger,long> Eval(int a){
			return Eval(new Count(a));
		}
		public static Dictionary<BigInteger, long> Eval(N u) {
			 return Eval(new Count(u));
		
		}

		public static Dictionary<BigInteger,long> Eval(Count u) { 
			//first iterate each prime under c...

			//get the sqrt of u

			if (u.val==1)
			{
				return new Dictionary<BigInteger,long>();
				
			}

			return _EvalRecur(u.val);

		}

		
	}
}
