using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using N=nilnul.num.natural.Natural_bigInteger;

namespace nilnul.num.natural.collection.op
{
	public partial class Max
	{

		static public N Eval(N x) {
			return x;
		}
		static public N Eval(long x, long y) {
			return new N( x > y ? x : y);
		}
		static public N Eval(N x, N y) {
			return x > y ? x : y;
		}
		static public N Eval(IEnumerable<N> nonEmpty) {
			if (nonEmpty.Count()==1)
			{
				return nonEmpty.First();
				
			}
			return Eval(nonEmpty.First(), Eval(nonEmpty.Skip(1)));
		}
	}
}
