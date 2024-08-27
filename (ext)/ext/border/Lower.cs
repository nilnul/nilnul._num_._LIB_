using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ext_.border
{
	static public class LowerX
	{
		static public bool LowerContain(this Border lower , ExtA x) {
			return nilnul.comparer.border.Lower.Contain<ExtA, ext_.Comparer, Border>(lower, x);
		}
		static public bool LowerContain(this Border1 lower , ExtA1 x) {
			return nilnul.comparer.border.Lower.Contain<ExtA1, ext_.Comparer1, Border1>(lower, x);
		}

	}
}
