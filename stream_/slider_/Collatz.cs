using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul._num.bigint.be;
using nilnul.num._num.bigint.be;
using N = nilnul._num.bigint.be.Natural.Asserted;
using P = nilnul.num_.Positive;

namespace nilnul.num.stream_.slider_
{
	/// <summary>
	/// if the first is nil, the remaining are all 0s
	/// if the first is positive, see <see cref="nameof(nilnul.num_.positive.Stre.strea)"/>
	/// </summary>
	public  class Collatz:
		nilnul.num.stream_.SliderA
		,
		nilnul.num.stream_.SliderI4
	{
		

		private nilnul.Num1 _current;

		

		public override nilnul.Num1 current
		{
			get
			{
				return  _current;
			}
		}


		public Collatz( nilnul.Num1 p)
		{
			_current = p;

		}

		/// <summary>
		/// collatz conjecture states that this always reach the cycle 1,2,4,1,...
		/// </summary>
		

		public override void moveNext()
		{
			///if the first is nil, then the remaining are all nils
			_current = new Num1( _current%2==0 ? _current/2: 3*_current +1);

		}
	}
}
