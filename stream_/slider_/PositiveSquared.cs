using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul._num.bigint.be;
using nilnul.num._num.bigint.be;
using N = nilnul.Num1;

namespace nilnul.num.stream_.slider_
{
	public  class PositiveSquared:SliderA
	{
		

		private BigInteger _index;


		public override N current
		{
			get
			{
				return new N(  _index*_index);
			}
		}

		public PositiveSquared()
		{
			_index = 1;

		}

		public override void moveNext()
		{
			_index ++;
		}
	}
}
