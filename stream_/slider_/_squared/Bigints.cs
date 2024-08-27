using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul._num.bigint.be;
using nilnul.num._num.bigint.be;
using N = nilnul.Num1;

namespace nilnul.num.stream_.slider_._squared
{
	public  class Bigints
		:
		nilnul._num.bigint.stream_.SliderA

	{
		

		private BigInteger _index;


		public override I current
		{
			get
			{
				return   _index*_index;
			}
		}

		public Bigints()
		{
			_index =0;

		}

		public override void moveNext()
		{
			_index ++;
		}
	}
}
