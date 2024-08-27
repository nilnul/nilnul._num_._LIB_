using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num_;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num
{
	//extern alias obj;
	[Obsolete()]
	public class Border1:
		//obj::
		nilnul.obj.Border<Num>,
		BorderI
	{
		public Border1(bool openFalseCloseTrue, Num mark):base(openFalseCloseTrue,mark)
		{

		}
		static public Border1 CreateClose(Num mark) {
			return new Border1(true, mark);
		}

		static public Border1 CreateOpen(Num mark) {
			return new Border1(false, mark);
		}

		public static Border1 CreateOpen(Positive y)
		{
			return new Border1(false, y);

			throw new NotImplementedException();
		}
	}
}
