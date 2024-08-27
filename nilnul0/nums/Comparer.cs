using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.str
{
	static public class _Comparer_assumeStrOfNumX
	{
		static public int Compare_assumeHeadeds(IEnumerable<BigInteger> x, IEnumerable<BigInteger> y)
		{
			var compared = x.First().CompareTo(y.First());

			if (compared == 0)
			{
				return Compare(nilnul.obj.seq_.headed._TailX._Tail(x), nilnul.obj.seq_.headed._TailX._Tail(y));
			}
			return compared;
		}
		static public int Compare_assumeFormerHeaded(IEnumerable<BigInteger> x, IEnumerable<BigInteger> y)
		{

			if (y.Any())
			{
				return Compare_assumeHeadeds(x, y);

			}
			return 1;

		}

		static public int Compare(IEnumerable<BigInteger> x, IEnumerable<BigInteger> y)
		{
			if (x.Any())
			{

				return Compare_assumeFormerHeaded(x, y);

			}
			if (y.Any())
			{
				return -Compare_assumeFormerHeaded(y, x);
			}
			return 0;
		}


	}


	public class Comparer_assumeStrOfNum : IComparer<IEnumerable<BigInteger>>
	{
		public int Compare(IEnumerable<BigInteger> x, IEnumerable<BigInteger> y)
		{
			return _Comparer_assumeStrOfNumX.Compare(x, y);
		}

		static public Comparer_assumeStrOfNum Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Comparer_assumeStrOfNum>.Instance;
			}
		}

	}
}
