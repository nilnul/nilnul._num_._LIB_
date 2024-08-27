using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
using nilnul.obj._slider_;
using nilnul.obj.stream_._slider._cursor_;
using N = nilnul.Num;

namespace nilnul.num
{
	[Obsolete()]
	public interface SliderI2
		:nilnul.obj.SliderI<N>
	{
	}

	public abstract class SliderA : SliderI2, SliderI1
	{
		public abstract N current { get; }

		//NumI CurrentI<NumI>.current => current;

		//NumI obj.stream_._slider._cursor_.CurrentI<NumI>.current => current;

		NumI obj.stream_._slider._skid_.CurrentI<NumI>.current => current;

		public abstract void moveNext();
	}

	[Obsolete()]
	public class Slider1 :
		nilnul.obj.Box<nilnul.obj.SliderI<N>>
		,
		SliderI2
	{
		public Slider1(SliderI<N> val) : base(val)
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
