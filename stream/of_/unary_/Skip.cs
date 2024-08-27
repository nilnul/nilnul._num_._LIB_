using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num.stream.op_
{
	public class Skip
	{
		static public StreamI3 Eval(StreamI3 s, N n) {
			return new _skip.Ret(n, s);
		}

		static public StreamI3 Eval(StreamI3 s) {
			return Eval(s, 1);
		}
	}
}
