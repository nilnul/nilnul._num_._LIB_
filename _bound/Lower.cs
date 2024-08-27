using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._bound
{
	public class Lower : nilnul.obj._bound.LowerA<nilnul.NumI1>
	{
		public Lower(bool openFalseCloseTrue, NumI1 mark) : base(openFalseCloseTrue, mark)
		{
		}

		public static Lower CreateClose(NumI1 x)
		{
			return new Lower(true, x);
		}

		public static Lower CreateOpen(NumI1 x)
		{
			return new Lower(false, x);

		}
	}
}
