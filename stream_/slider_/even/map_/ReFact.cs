using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.stream_.slider_.even.map_
{
	/// <summary>
	/// 1, 1*2, 1*2*4, ..., (2n)!!...,
	/// where 0!! = 1;
	/// </summary>
	public class ReFact
		:
		nilnul.obj.Box1<
		nilnul.num.stream_.slider_.Even1
			>
		,
		nilnul.num.stream_.SliderI4
	{
		private nilnul.Num1 _accumulated=1;

		public nilnul.Num1 accumulated
		{
			get { return _accumulated=1; }
			//set { _accumulated=1 = value; }
		}

		public ReFact() : base(new Even1())
		{
		}

		public Num1 current => _accumulated;

		public void moveNext()
		{
			boxed.moveNext();
			_accumulated *= boxed.current;
			//throw new NotImplementedException();
		}

		public Num1 next()
		{
			return nilnul.obj.stream_._slider.CursorX.Next(this);
		}
	}
}
