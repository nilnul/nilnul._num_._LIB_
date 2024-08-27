using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.border
{
	public class Duo :
		nilnul.obj.border.Duo1<Num, BorderI,BorderI>
	{
		public Duo(Border1 item1, Border1 item2) : base(item1, item2)
		{

		}

		public Duo(BorderI item1, BorderI item2) : base(item1, item2)
		{

		}

		static public Duo CreateClose(nilnul.Num lower, nilnul.Num upper) {
			return new Duo(
				Border1.CreateClose(lower)
				,
				Border1.CreateClose(upper)
			);
		}

		public static Duo CreateClose(Duo1 duo1)
		{
			return CreateClose(duo1.Item1,duo1.Item2);
			//throw new NotImplementedException();
		}
	}
}
