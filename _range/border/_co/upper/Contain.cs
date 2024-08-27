using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace nilnul.num.border._co.upper
{
	public class Contain
	{
		static public bool Eval(nilnul.num.Border2 upper, Num1 x) {
			return ToOpen.Eval(upper).mark > x;
		}
		static public bool Eval(nilnul.num.BorderI2 upper, Num1 x) {
			return ToOpen.Eval(upper).mark > x;
		}

		static public bool Eval(nilnul.num.BorderI2 upper, NumI1 x) {
			return ToOpen.Eval(upper).mark > x;
		}

	}
}
