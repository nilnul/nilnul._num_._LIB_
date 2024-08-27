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
	public  class Odd1:SliderA
		,
		nilnul.obj.stream_.slider_._FuncI
	{
		

		private BigInteger _current=1;

		

		public override N current
		{
			get
			{
				return new nilnul.Num1( _current);
			}
		}

		public Odd1()
		{
			//_current = 1;

		}

		public override void moveNext()
		{
			_current += 2;
		}

		public void setIndex(N num)
		{
			_current = 2*num+1;
			//throw new NotImplementedException();
		}

		public void moveNext(N num)
		{
			_current += 2*num;
			//throw new NotImplementedException();
		}
	}
}
