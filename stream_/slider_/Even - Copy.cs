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
	public  class Even1:SliderI1
	{
		

		private BigInteger _current;// /*default */=0;

		

		public N current
		{
			get
			{
				return new nilnul.Num( _current);
			}
		}

		public Even1()
		{
			//_current = 0;

		}

		public void moveNext()
		{
			_current += 2;
		}
	}
}
