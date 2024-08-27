using System;
using System.Net;
using System.Numerics;
using nilnul._num.bigint.be;
using nilnul.num._num.bigint.be;
using N = nilnul.num._num.bigint.be.Natural.Asserted;

namespace nilnul.num.duo
{
	[Obsolete()]
	public  class Op
		:
		nilnul.obj.duo.op.Closed<N>
		,
		OpI
	{
		public Op(Func<N,N,N> func)
			:base(func)
		{

		}


		public nilnul._num.bigint.be.Natural.Asserted eval(nilnul._num.bigint.be.Natural.Asserted a, nilnul._num.bigint.be.Natural.Asserted b)
		{
			throw new NotImplementedException();
		}
	}
}
