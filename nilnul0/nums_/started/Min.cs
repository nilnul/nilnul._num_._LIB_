using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.str_.started
{
	public static class _MinX
	{
		

		static public nilnul.NumI _Min(this IEnumerable<NumI> nums_seeded) {
			var tail = nilnul.objs_.started._TailX._Tail(nums_seeded);
			if (tail.Any())
			{
				return nilnul.num.combine_.Min.Singleton.combine( nums_seeded.First(), _Min(tail) );
			}

			return nums_seeded.First();

		}


	}
}
