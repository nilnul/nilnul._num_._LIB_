using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.border
{
	public class Co :
		nilnul.obj.border.Co<Num1, BorderI2,BorderI2>
	{
		public Co(Border2 item1, Border2 item2) : base(item1, item2)
		{

		}

		public Co(BorderI2 item1, BorderI2 item2) : base(item1, item2)
		{

		}

		static public Co CreateClose(nilnul.Num1 lower, nilnul.Num1 upper) {
			return new Co(
				Border2.CreateClose(lower)
				,
				Border2.CreateClose(upper)
			);
		}

		public static Co CreateClose(nilnul.num.Co duo1)
		{
			return CreateClose(duo1.Item1,duo1.Item2);
			//throw new NotImplementedException();
		}

		public static Co CreateClose(BigInteger a, BigInteger b)
		{
			return CreateClose(new Num1(a), new Num1(b));
		}
	}
}
