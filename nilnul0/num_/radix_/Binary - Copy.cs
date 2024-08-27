using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix_
{
	public class Binary:nilnul.num_.Radix
	{
		[Obsolete()]
		public Binary(IEnumerable<Num> digits ):base((Plural)2, new nums_.List( digits))
		{

		}

		public Binary(params int[] digits):this(
			digits.Select(x=>new nilnul.Num1(x))
		)
		{
		}

		public Binary(IEnumerable<Num1> enumerable):this( enumerable.Select(x=> (Num)x))
		{
		}

		static public explicit operator Binary(int i) {
			return new Binary( _radix.root_.Dec.ToDigits(i));
		}
	}
}
