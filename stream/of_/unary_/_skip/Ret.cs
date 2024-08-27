using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using N = nilnul.Num1;

namespace nilnul.num.stream.op_.unary_._skip
{
	public class Ret:op_._unary.Ret

	{
		public Ret(StreamI6 n):this(1,n)
		{

		}

		

		public Ret(N n , StreamI6 s):base(s)
		{
			

			while (n >0)
			{
				s.next();
				n--;
			}

		}

		public override N next()
		{
			return arg.next();
			//throw new NotImplementedException();
		}
	}
}
