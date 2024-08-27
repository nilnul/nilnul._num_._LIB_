using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix_
{
	[Obsolete()]
	public class Dec:nilnul.num_.Radix
	{
		public Dec(IEnumerable<Num> digits ):base((Plural)10, new nums_.List( digits))
		{

		}
		public Dec(IEnumerable<Num1> digits ):base((Plural)10, new num.str_.List( digits))
		{

		}


		static public Dec Create(Num x) {
			return new Dec(
				_radix.root_.Dec.ToDigits(x)
			);
		}

		static public Dec Create(int x) {
			return Create(new Num(x));
		}

		static public explicit operator Dec(int i) {
			return new Dec( _radix.root_.Dec.ToDigits(i));
		}

		public override string ToString()
		{
			return string.Join("", (this.digits as IEnumerable<nilnul.Num>).Reverse());
		}


	}
}
