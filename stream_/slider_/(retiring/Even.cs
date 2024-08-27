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
	public  class Even:SliderI
	{
		

		private BigInteger _current;// /*default */=0;

		

		public N current
		{
			get
			{
				return new N( _current);
			}
		}

		public Even()
		{
			_current = 0;

		}

		public void moveNext()
		{
			_current += 2;
		}
	}
}
