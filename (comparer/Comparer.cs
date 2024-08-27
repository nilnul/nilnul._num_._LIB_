using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.bigint.be;
using N = nilnul.num.bigint.be.Natural.Asserted;
using System.Numerics;

namespace nilnul.num
{
	public class Comparer : IComparer<N>
	{

		static public readonly Comparer Instance = new Comparer();
		public int Compare(N x, N y)
		{
			return BigInteger.Compare(x, y);
			throw new NotImplementedException();
		}
	}
}
