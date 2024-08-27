using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using nilnul.num._num.bigint.be;
using nilnul.num.type._stream;
using nilnul._num.bigint.be;
using nilnul.obj._stream_;

namespace nilnul.num.stream_
{
	[Obsolete()]
	public class Factorial1
		: StreamI4
	{
		private BigInteger _n;

		public BigInteger n
		{
			get { return _n; }
			set { _n = value; }
		}

		public NumI next()
		{
			return new nilnul.Num(
				nilnul.num.op_.unary_._FactorialX._Op_byLoop(_n++)
			);
		}

		public void reset()
		{
			_n = 0;
		}

	}
}
