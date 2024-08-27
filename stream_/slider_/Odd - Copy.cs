using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul._num.bigint.be;
using nilnul.num._num.bigint.be;
using N = nilnul.NumI;

namespace nilnul.num.slider_
{
	public  class Odd1:SliderI1
	{
		

		private BigInteger _current=1;

		

		public N current
		{
			get
			{
				return new nilnul.Num( _current);
			}
		}

		public Odd1()
		{
			//_current = 1;

		}

		public void moveNext()
		{
			_current += 2;
		}
	}
}
