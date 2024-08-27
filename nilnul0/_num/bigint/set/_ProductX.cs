using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.set
{
	static public class _ProductX
	{
		static public int Product(this IEnumerable<int> x) {
			return x.Aggregate(
				1,
				(a,c) => a*c
			);
		}
	}
}
