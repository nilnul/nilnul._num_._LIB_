using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.op
{
	public class SwapX
	{
		

		static public void Swap(ref int x,  ref int y)
		{
			y^=x ^= y;
			x ^= y;
		}
	}
}
