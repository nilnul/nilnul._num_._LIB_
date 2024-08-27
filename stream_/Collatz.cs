using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num._num.bigint.be;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num.stream_
{
	static public  class _CollatzX
	{
		static public nilnul.num.SliderI3 Gen(nilnul.NumI1 num) {
			if (num.toBigint().en==0)
			{

				return new nilnul.num.slider_.Constant(0); 
			}

			return 
				new num_.positive.slider_.Collatz1(num)
			;
		}
	}
}
