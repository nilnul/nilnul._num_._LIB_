using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.nums_.started
{
	public static class _MaxX
	{
		static public int Eval(int a, int b) {
			return Math.Max(a, b);
		}


		static public int Eval(int a, int b, int c) {
			return Math.Max(Math.Max(a, b), c);
		}
		static public nilnul.Num Eval(Num x, Num y) {
			return x >= y ? x : y;
		}

		static public nilnul.Num _Eval(this IEnumerable<Num> nums_seeded) {
			var tail = nilnul.objs_.started._TailX._Tail(nums_seeded);
			if (tail.Any())
			{
				return Eval( nums_seeded.First(), _Eval(tail) );
			}
			return nums_seeded.First();


		}

	}
}
