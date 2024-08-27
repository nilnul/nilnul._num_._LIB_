using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;

namespace nilnul.num.stream.op_._unary
{
	public abstract class Ret
		:nilnul.obj.op_.unary._call.ArgA<StreamI6 >
		,StreamI6
	{
		public Ret(StreamI6 n):base(n)
		{

		}

		public abstract Num1 next();
	}
}
