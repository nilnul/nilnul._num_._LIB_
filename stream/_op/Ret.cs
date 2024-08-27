using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num.stream._op
{
	public abstract class Ret
		:nilnul.Box1<StreamI3>
		,StreamI3
	{
		public Ret(StreamI3 n):base(n)
		{

		}

		public abstract N next();
	}
}
