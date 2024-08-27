using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._num.bigint.stream_
{
	public class Natural
		:
		nilnul._num.bigint.StreamI
	{
		BigInteger _current = 0;
		public BigInteger next()
		{
			return _current++;
		}

	}
}
