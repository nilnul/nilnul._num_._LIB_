using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.nums_.stuffed
{
	public static class _MaxX
	{
		static public int Eval(int a, int b) {
			return Math.Max(a, b);
		}


		static public int Eval(int a, int b, int c) {
			return Math.Max(Math.Max(a, b), c);
		}
		static public nilnul.Num1 Eval(Num1 x, Num1 y) {
			return x >= y ? x : y;
		}

		static public nilnul.Num1 _Cumulate(this IEnumerable<Num1> _nums_seeded) {
			var tail = nilnul.objs_.started._TailX._Tail(_nums_seeded);
			if (tail.Any())
			{
				return Eval( _nums_seeded.First(), _Cumulate(tail) );
			}
			return _nums_seeded.First();
		}

		static public nilnul.Num1 _Cumulate_byLoop(this IEnumerable<Num1> _nums_seeded) {

			var enumerator = _nums_seeded.GetEnumerator();

			enumerator.MoveNext();

			var r = enumerator.Current;

			while (enumerator.MoveNext())
			{
				r = enumerator.Current > r ? enumerator.Current:r;
			}

			return r;
		}
	}
}
