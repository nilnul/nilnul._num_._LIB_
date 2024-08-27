using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using nilnul.num.ext_.border;

namespace nilnul.num.ext_
{
	public class Border1: Border<ExtA1>
	{
		public Border1(bool openFalseCloseTrue, ExtA1 mark)
			:base(openFalseCloseTrue,mark)
		{

		}

		static public Border1 CreateClose(ExtA1 x) {
			return new Border1(true, x);
		}
		static public Border1 CreateOpen(ExtA1 x) {
			return new Border1(false, x);
		}

		internal static Border1 CreateClose(Natural.Asserted lower)

		{
			return CreateClose(
				new ext_.Basic( new nilnul.Num(lower))
			);
		}

		//public Border1 toClosed() {
		//	return CreateClose(this.mark);	//get to the closest the close border. but it cannot be done when it's open infinity.
		//}
	}
}
