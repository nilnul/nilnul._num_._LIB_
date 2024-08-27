using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.plural._radix.root_
{
	public class Dec
	{
		static public List<nilnul.Num> ToDec(nilnul.Num num) {
			return new nilnul.num_.plural._radix.Root(10).toRadix(num);
		}
	}
}
