using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.set
{
	static public class _GregateX
	{
		[Obsolete(nameof(Enumerable.Sum))]
		static public int Sum(this IEnumerable<int> x) {
			return x.Sum();
		}
	}
}
