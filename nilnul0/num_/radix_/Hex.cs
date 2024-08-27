using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix_
{
	public class Hex:nilnul.num_.Radix1
	{
		public Hex(IEnumerable<Num1> digits ):base((Plural)16, new num.str_.List( digits))
		{

		}
		public Hex(IEnumerable<Num> digits) : this(digits.Select(x=> new Num1(x)))
		{

		}

		public Hex(IEnumerable< int> digits) : this(
			digits.Select(x => new nilnul.Num1(x))
		)
		{
		}

		public Hex(params int[] digits) : this(
			digits.Select(x => new nilnul.Num1(x))
		)
		{
		}

		static public Hex Parse(string s)
		{
			return new Hex(
				s.Select(
					c => _hex._GitX.GitAsInt(c)
				)
			);
		}


	}
}
