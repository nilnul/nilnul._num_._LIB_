using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num_;
using N = nilnul.Num1;

namespace nilnul.num
{
	//extern alias obj;
	public class Border2:
		//obj::
		nilnul.obj.Border<N>,BorderI2
	{
		public Border2(bool openFalseCloseTrue, N mark):base(openFalseCloseTrue,mark)
		{

		}
		static public Border2 CreateClose(N mark) {
			return new Border2(true, mark);
		}

		static public Border2 CreateOpen(N mark) {
			return new Border2(false, mark);
		}

		public static Border2 CreateOpen(Positive1 y)
		{
			return new Border2(false, y);

		}
	}
}
