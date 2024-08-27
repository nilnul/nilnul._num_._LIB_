using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.cast_
{
	public class Sqrt
		: nilnul.num.CastI<nilnul.num.Range>
	{
		public Range cast(Num num)
		{
			if (num == 0)
			{
				return Range.CreateSingleton((Num)0);
			}
			if (num == 1)
			{
				return Range.CreateSingleton((Num)1);
			}
			BigInteger lower = 0;
			BigInteger upper = num;

			BigInteger middle ;
			BigInteger middleSquared;

			while (upper - lower > 1)
			{
				middle = (lower + upper) / 2;
				middleSquared = middle * middle;
				if (middleSquared < num)
				{
					lower = middle;
					middle = (lower + upper) / 2;
				}
				else
				{
					upper = middle;
					middle = (lower + upper) / 2;
				}

				if (middleSquared == num)
				{
					return Range.CreateSingleton((nilnul.Num)middle);
				}
			}



				return  Range.CreateOpen(lower, upper);
		
		}


		static public readonly Sqrt Singleton = nilnul.obj.SingletonByDefault<Sqrt>.Instance;

	}
}
