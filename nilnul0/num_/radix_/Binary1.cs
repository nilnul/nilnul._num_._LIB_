using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix_
{
	public class Binary1:nilnul.num_.Radix1
	{
		public Binary1(IEnumerable<Num1> digits ):base((Plural)2, new num.str_.List( digits))
		{

		}
		public Binary1(IEnumerable<Num> digits) : this(digits.Select(x=> new Num1(x)))
		{

		}

		public Binary1(IEnumerable< int> digits) : this(
			digits.Select(x => new nilnul.Num1(x))
		)
		{
		}

		public Binary1(params int[] digits) : this(
			digits.Select(x => new nilnul.Num1(x))
		)
		{
		}

		static public Binary1 Parse(string s)
		{
			return new Binary1(
				s.Select(
					c => _bin._GitX.GitAsInt(c)
				)
			);
		}


	}
}
