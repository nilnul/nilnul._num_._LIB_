using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.stream.op_.unary_
{
	public class Increment : nilnul.num.stream.op_.UnaryI
	{
		public StreamI6 op(StreamI6 par)
		{
			return new _incre.Ret(par);
		}

	}
}
