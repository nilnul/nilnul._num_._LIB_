using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using N = nilnul._num.bigint.op.Abs.Ed;

namespace nilnul.num.op
{
	public partial class DivRem
	{
		static public uint[] Eval(uint dividend, uint divisor)
		{

			return new uint[] { dividend / divisor, dividend % divisor };
		}

		static public uint Eval(ref uint dividend, uint divisor)
		{
			var r = dividend / divisor;

			dividend %= divisor;

			return r;
		}
		static public uint[] Eval( int dividend, int divisor)
		{
			return Eval((uint)dividend, (uint)divisor);

		}

			static public int[] Eval_retInt(int dividend, int divisor)
		{

			return new int[] { dividend / divisor, dividend % divisor };
		}

	

	}
}
