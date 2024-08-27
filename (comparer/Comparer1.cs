using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.bigint.be;
using N = nilnul._num.bigint.be.Natural.Asserted;
using System.Numerics;

namespace nilnul.num
{
	[Obsolete()]
	public class Comparer1 : IComparer<N>
	{

		static public readonly Comparer1 Instance = new Comparer1();

		public int Compare(int version1, int version2)
		{
			return version1.CompareTo(version2);
		}

		public int Compare(N x, N y)
		{
			return BigInteger.Compare(x, y);
		}
	}
}
