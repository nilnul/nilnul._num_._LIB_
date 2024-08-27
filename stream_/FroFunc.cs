using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num.stream
{
	public class FroFunc:nilnul.Box1<Func<N, N>>
		,StreamI3
	{
		stream_.Num _num;
		Func<N, N> _func;
		public FroFunc(Func<N,N> func):base(func)
		{
			_num = new stream_.Num();
			_func = func;
		}

		public N next()
		{
			return _func(_num.next());
			//throw new NotImplementedException();
		}
	}

}
