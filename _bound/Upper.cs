using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._bound
{
	public class Upper : nilnul.obj._bound.UpperA<nilnul.NumI1>
	{
		public Upper(bool openFalseCloseTrue, NumI1 mark) : base(openFalseCloseTrue, mark)
		{
		}

		public static Upper CreateClose(NumI1 x)
		{
			return new Upper(true, x);
		}

		public static Upper CreateOpen(NumI1 x)
		{
			return new Upper(false, x);

		}
	}
}
