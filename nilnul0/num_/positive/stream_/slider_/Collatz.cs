using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul._num.bigint.be;
using nilnul.num._num.bigint.be;
using P = nilnul.num_.Positive1;

namespace nilnul.num_.positive.stream_.slider_
{
	public  class Collatz: nilnul.num_.positive.stream_.SliderA2
	{
		

		private P _current;

		

		public override P current
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
		public override void moveNext()
		{
			var _c = _current.en;
			_current = new P( _c%2==0 ? _c/2: 3*_c+1);
		}
	}
}
