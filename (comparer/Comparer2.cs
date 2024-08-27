using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.bigint.be;
using N = nilnul.NumI;
using System.Numerics;

namespace nilnul.num
{
	public class Comparer2 : IComparer<N>,IComparer<nilnul.NumI1>
	{


		

		public int Compare(N x, N y)
		{
			return BigInteger.Compare(x.toBigint(), y.toBigint());
		}

		public int Compare(NumI1 x, NumI1 y)
		{
			return BigInteger.Compare(x.toBigint(), y.toBigint());
		}

		static public Comparer2 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Comparer2>.Instance;
			}
		}




	}
}
