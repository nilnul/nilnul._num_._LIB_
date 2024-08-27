using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using N = nilnul.num.natural.Natural_bigInteger;

namespace nilnul.num.natural.collection.op
{
	static public class SumX
	{
			static public Natural_bigInteger Sum(IEnumerable<Natural_bigInteger> numbers)
		{

			return numbers.Aggregate(Natural_bigInteger.GetZero1(), (a, c) => c + a);

		}
	
	}
}
