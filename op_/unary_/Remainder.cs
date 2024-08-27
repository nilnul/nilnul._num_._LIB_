using System;
using System.Net;
using System.Numerics;
using nilnul.num.natural;
using nilnul.num.natural.relation;
using nilnul.num_;

namespace nilnul.num.op_.unary_
{
	public  class Remainder
		:nilnul.obj.Box1<nilnul.num_.Positive1>
		,
		nilnul.num.op_.UnaryI1
	{
		public Remainder(Positive1 val) : base(val)
		{
		}

		public NumI1 op(NumI1 dividend) {

			return new Num1(BigInteger.Remainder(dividend.toBigint(), boxed.toBigint()));
		}

		public NumI1 op(int dividend) {

			return op(new Num1(dividend) );
		
		}

		public Num1 op(Num1 par)
		{
			return new Num1(BigInteger.Remainder(par.toBigint(), boxed.toBigint()));

		}
	}

}
