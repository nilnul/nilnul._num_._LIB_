using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
using N = nilnul.NumI;

namespace nilnul.num
{
	[Obsolete()]
	public interface SliderI1
		:nilnul.obj.SliderI<N>
	{
	}
	[Obsolete()]
	public class Slider :
		nilnul.obj.Box<nilnul.obj.SliderI<N>>
		,
		SliderI1
	{
		public Slider(SliderI<N> val) : base(val)
		{
		}

		public N current => boxed.current;

		public void moveNext()
		{
			boxed.moveNext();
		}

		//static public implicit operator Slider(nilnul.obj.sl) { }
	}
}
