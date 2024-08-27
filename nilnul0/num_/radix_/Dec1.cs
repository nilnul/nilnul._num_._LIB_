using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix_
{
	public class Dec1:nilnul.num_.Radix2
	{
		public Dec1(IEnumerable<Num1> digits ):base(10, new nums_.ListOfClass( digits))
		{
		}

		public Dec1(IEnumerable<int> enumerable):this(
			enumerable.Select(
				a=> new Num1(a)
			)
		)
		{
		}
		public Dec1():this(new Num1[0])
		{
		}

		static public Dec1 Parse(string s) {
			return new Dec1(
				s.Select(
					c=> _dec._GitX.GitAsInt(c)
				).Reverse()
			);
		}

		static public Dec1 Create(Num1 x) {
			return new Dec1(
				_radix.root_.Dec.ToDigits(x)
			);
		}

		static public Dec1 Create(NumI1 x) {
			return new Dec1(
				_radix.root_.Dec.Singleton._toPositions(x)
			);
		}

		static public Dec1 Create(int x) {
			return Create(new Num1(x));
		}

		static public Dec1 Create(BigInteger x) {
			return Create(new Num1(x));
		}

		static public explicit operator Dec1(int i) {
			return new Dec1( _radix.root_.Dec.Singleton._toPositions(i));
		}

		public override string ToString()
		{
			return string.Join("", (this.digits as IEnumerable<nilnul.Num1>).Reverse());
		}


	}
}
