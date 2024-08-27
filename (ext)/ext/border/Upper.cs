using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ext_.border
{
	static public class UpperX
	{
		static public bool UpperContain(this Border upper , ExtA x) {
			return nilnul.comparer.border.Upper.Contain<ExtA, ext_.Comparer, Border>(upper, x);
		}
		static public bool UpperContain(this Border1 upper , ExtA1 x) {
			return nilnul.comparer.border.Upper.Contain<ExtA1, ext_.Comparer1, Border1>(upper, x);
		}
	}
}
