using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using N = nilnul.Num1;

namespace nilnul.num.stream.op_.unary_._incre
{
	public class Ret:op_._unary.Ret

	{
		public Ret(StreamI6 n):base(n)
		{
		}

		

		

		public override N next()
		{
			return arg.next()+1;
			//throw new NotImplementedException();
		}
	}
}
