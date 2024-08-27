using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;


namespace nilnul.num.border._duo_.upper
{
	public class Contain
	{
		static public bool Eval(nilnul.num.Border1 upper, Num x) {
			return ToOpen.Eval(upper).mark > x;
		}
		static public bool Eval(nilnul.num.BorderI upper, Num x) {
			return ToOpen.Eval(upper).mark > x;
		}

		static public bool Eval(nilnul.num.BorderI upper, NumI x) {
			return ToOpen.Eval(upper).mark > x.toBigint();
		}

	}
}
