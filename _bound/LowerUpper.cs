using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._bound
{
	public class LowerUpper : nilnul.obj._bound.LowerUpperA<nilnul.NumI1, Lower, Upper>
	{
		public LowerUpper(Lower lower, Upper upper) : base(lower, upper)
		{
		}

		static public LowerUpper CreateClose(nilnul.NumI1 x, nilnul.NumI1 y) {
			return new LowerUpper(
				Lower.CreateClose(x)
				,
				Upper.CreateClose(y)
			)
				;
		}

		static public LowerUpper CreateClose(nilnul.Num1 x, nilnul.Num1 y) {
			return new LowerUpper(
				Lower.CreateClose(x)
				,
				Upper.CreateClose(y)
			)
				;
		}
		static public LowerUpper CreateOpen(nilnul.NumI1 x, nilnul.NumI1 y) {
			return new LowerUpper(
				Lower.CreateOpen(x)
				,
				Upper.CreateOpen(y)
			);
		}
		static public LowerUpper CreateOpen(nilnul.Num1 x, nilnul.Num1 y) {
			return new LowerUpper(
				Lower.CreateOpen(x)
				,
				Upper.CreateOpen(y)
			);
		}

		static public LowerUpper CreateOpen(BigInteger x, BigInteger y) {
			return CreateOpen(new nilnul.Num1(x), new nilnul.Num1(y));
				;
		}
		static public LowerUpper CreateClose(BigInteger x, BigInteger y) {
			return CreateClose(new nilnul.Num1(x), new nilnul.Num1(y));
				;
		}

		static public LowerUpper CreateSingle(nilnul.NumI1 x) {
			return CreateClose(x,x);
				;
		}
		static public LowerUpper CreateSingle(nilnul.Num1 x) {
			return CreateClose(x,x);
				;
		}

		static public LowerUpper CreateSingle(BigInteger x) {
			return CreateSingle(new nilnul.Num1(x));
				;
		}



	}
}
