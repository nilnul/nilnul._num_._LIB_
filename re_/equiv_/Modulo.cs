using nilnul.num_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.re_.equiv_
{
	 public class Modulo:
		nilnul.obj.Box1<
			nilnul.num_.Positive1
		>
		,
		nilnul.num.ReI
	{
		public Modulo(Positive1 val) : base(val)
		{
		}

		public Modulo(BigInteger p):this(new Positive1(p))
		{
		}

		static public bool Re(in BigInteger a, in BigInteger b, in BigInteger _dividend_positive) {
			return BigInteger.Remainder(a, _dividend_positive) == BigInteger.Remainder(b, _dividend_positive);
		}

		public bool re(NumI1 a, NumI1 b)
		{
			return Re( a.toBigint(), b.toBigint(), boxed.toBigint());

		}
	}
}
