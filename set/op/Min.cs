using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.set.op
{
	public class Min
	{
		static public int Eval(int a, int b) {
			return Math.Min(a, b);
		}


		static public int Eval(int a, int b, int c) {
			return Math.Min(Math.Min(a, b), c);
		}
	}
}
