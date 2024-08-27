using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._stream_;
using N = nilnul.NumI;


namespace nilnul.num.slider
{
	public class FroStream
		: nilnul.obj.slider.FroStream<N>
	{
		public FroStream(NextI<N> val) : base(val)
		{

		}
	}
}
