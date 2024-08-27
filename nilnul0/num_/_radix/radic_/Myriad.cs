using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_._radix.root_
{
	public class Myriad
	{
		static public nilnul.nums_.List ToDigits(nilnul.Num num) {
			return new nilnul.num_._radix.Root(10000)._toDigits(num);
		}

		static public nilnul.nums_.List ToDigits(int num)
		{
			return new nilnul.num_._radix.Root(10000)._toDigits(num);
		}

	}
}
