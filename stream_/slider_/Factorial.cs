using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using nilnul.num._num.bigint.be;
using nilnul.num.type._stream;
using nilnul._num.bigint.be;
using nilnul.obj._stream_;

namespace nilnul.num.stream_.slider_
{
	public class Factorial
		:
		nilnul.obj.box_.OfNew<stream_.slider_.Positive>
		,
		SliderI4
	{
		private BigInteger _accumulated=1;

		public BigInteger accumulated
		{
			get { return _accumulated; }
			set { _accumulated = value; }
		}

		public Num1 current => new Num1(accumulated);

		public void moveNext()
		{
			_accumulated *= boxed.next(); // we use next, which is a member of stream, thus fetching the slider's current;
		}

		public Num1 next()
		{
			return nilnul.obj.stream_._slider_.NextX.Next<Num1>(this);
			//var old=current;
			//moveNext();
			//return current;
		}
	}
}
