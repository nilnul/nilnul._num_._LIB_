using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul._num.bigint.be;
using nilnul.num._num.bigint.be;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num.slider_
{
	public  class Odd:SliderI
	{
		

		private BigInteger _current;

		

		public N current
		{
			get
			{
				return new N( _current);
			}
		}

		public Odd()
		{
			_current = 1;

		}

		public void moveNext()
		{
			_current += 2;
		}
	}
}
