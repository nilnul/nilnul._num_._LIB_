using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul._num.bigint.be;
using nilnul.num._num.bigint.be;
using N = nilnul._num.bigint.be.Natural.Asserted;
using P = nilnul.num_.Positive;

namespace nilnul.num_.positive.slider_
{
	[Obsolete(nameof(num_.positive.stream_.slider_.Collatz))]
	public  class Collatz:SliderI
	{
		

		private P _current;

		

		public P current
		{
			get
			{
				return  _current;
			}
		}

		public Collatz( P p)
		{
			_current = p;

		}

		/// <summary>
		/// collatz conjecture states that this always reach the cycle 1,2,4,1,...
		/// </summary>
		public void moveNext()
		{
			_current = new P( _current%2==0 ? _current/2: 3*_current +1);
		}
	}
}
