using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;


namespace nilnul.num.border._duo_.lower
{
	public class Contain
	{
		static public bool Eval(nilnul.num.Border1 lower, Num x) {
			return ToClosed.Eval(lower).mark <= x;
		}


		static public bool Eval(nilnul.num.BorderI lower, Num x) {
			return ToClosed.Eval(lower).mark <= x;
		}

		static public bool Eval(nilnul.num.BorderI lower, NumI x) {
			return ToClosed.Eval(lower).mark <= x.toBigint();
		}

	}
}
