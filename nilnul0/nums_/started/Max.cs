using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.str_.started
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

		static public nilnul.NumI _Max(this IEnumerable<NumI> nums_seeded) {
			var tail = nilnul.objs_.started._TailX._Tail(nums_seeded);
			if (tail.Any())
			{
				return nilnul.num.combine_.Max.Singleton.combine( nums_seeded.First(), _Max(tail) );
			}

			return nums_seeded.First();

		}

		static public nilnul.NumI1 _Max(this IEnumerable<NumI1> nums_seeded) {
			var tail = nilnul.objs_.started._TailX._Tail(nums_seeded);
			if (tail.Any())
			{
				return nilnul.num.op_.binary_.Max.Singleton.op( nums_seeded.First(), _Max(tail) );
			}

			return nums_seeded.First();

		}


	}
}
