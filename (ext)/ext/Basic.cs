using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.bigint.be;
using N = nilnul.Num;//._num.bigint.be.Natural.Asserted;

namespace nilnul.num.ext_
{
	public sealed class Basic
		:
		ExtA1,
		obj._member.ValI<N>
	{

		public Basic(N val)
		{
			_val = val;
		}

		private N _val;

		public N val
		{
			get
			{
				return _val;

				throw new NotImplementedException();
			}
		}
	}
}
