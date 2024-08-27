using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ext_.border
{
	public class Duo1:nilnul.border.Duo1<ExtA1,Border1>
	{
		public Duo1(Border1 lower, Border1 upper):base(lower, upper)
		{

		}

		public bool contain(ExtA1 x) {
			return lower.LowerContain(x) && upper.UpperContain(x);
		}
		public bool notContain(ExtA1 x) {
			return !contain(x);
		}

		//public ext.Duo toClosed() {
		//	return new ext.Duo(
		//		lower.toClosed().mark
				
		//		,
		//		upper.toClosed().mark	
		//	);
		//}


	}
}
