using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.stream_
{
	public class Natural
		:
		nilnul.num.integer._StreamI
	{
		BigInteger _current = 0;
		public BigInteger next()
		{
			return _current++;
		}

	}
}
