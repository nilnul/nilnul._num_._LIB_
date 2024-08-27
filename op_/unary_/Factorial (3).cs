using System;
using System.Collections;
using System.Numerics;
using nilnul._num.bigint.be;

namespace nilnul.num.op_.unary_
{
	[Obsolete(nameof(factorial_.Memoize))]
	public class Factorial : UnaryI
	{
		public Num op(Num arg)
		{
			return new Num(
				_FactorialX._Op_byLoop(arg.val)
			);
		}
	}
}