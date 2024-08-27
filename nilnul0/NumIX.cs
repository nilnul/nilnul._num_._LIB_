using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{

	static public class NumIX
	{
		static public nilnul.Num ToNum(this nilnul.NumI1 num) {
			return new Num(num.toBigint());
		}
		

	}
}
