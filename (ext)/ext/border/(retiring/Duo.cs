using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ext_.border
{
	public class Duo:nilnul.border.Duo1<ExtA,Border>
	{
		public Duo(Border lower, Border upper):base(lower, upper)
		{

		}

		public bool contain(ExtA x) {
			return lower.LowerContain(x) && upper.UpperContain(x);
		}
		public bool notContain(ExtA x) {
			return !contain(x);
		}


	}
}
