using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num.stream.op_._skip
{
	public class Ret:_op.Ret

	{
		public Ret(StreamI3 n):this(1,n)
		{

		}

		

		public Ret(N n , StreamI3 s):base(s)
		{
			

			while (n >0)
			{
				s.next();
				n--;
			}

		}

		public override N next()
		{
			return boxed.next();
			//throw new NotImplementedException();
		}
	}
}
