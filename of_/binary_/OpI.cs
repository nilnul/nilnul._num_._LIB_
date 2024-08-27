using System;
using System.Net;
using System.Numerics;
using nilnul._num.bigint.be;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num.duo
{
	public  interface OpI
		:
		obj.duo.op.ClosedI<N>
	{
		
	

		
	}

	public class Op1 :
		nilnul.duo.op_.froFunc_.Closed<N>
		, OpI
	{
		public Op1(Func<N, N, N> func) : base(func)
		{

		}
	}
}
