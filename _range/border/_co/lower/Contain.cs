using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul.Num1;


namespace nilnul.num.border._co.lower
{
	public class Contain
	{
		static public bool Eval(nilnul.num.Border2 lower, Num1 x) {
			return ToClosed.Eval(lower).mark <= x;
		}


		static public bool Eval(nilnul.num.BorderI2 lower, Num1 x) {
			return ToClosed.Eval(lower).mark <= x;
		}

		static public bool Eval(nilnul.num.BorderI2 lower, NumI1 x) {
			return ToClosed.Eval(lower).mark <= x;
		}

	}
}
