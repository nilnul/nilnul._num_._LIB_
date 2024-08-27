using nilnul.bit.stream_.slider_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.stream_.slider_
{
	/// <summary>
	/// map nilnul.bit.stream_.Alt into the realm of num
	/// 0,1,0,1
	/// </summary>
	/// <remarks>
	/// This also helps explain whey we put "false" as the head of the nilnul.bit.Stream, if we take the premise that 0 is false, and 1 is true
	/// </remarks>
	public class Alt :
		nilnul.obj.Box1<nilnul.bit.stream_.slider_.Alter>
		,
		nilnul.num.stream_.SliderI4
		,
		nilnul._obj.typ_.nilable_.unprimable_.INotSingularable
	{
		public Alt() : base(new Alter())
		{
		}

		public Num1 current => boxed.current?new Num1(1):new Num1(0);

		public void moveNext()
		{
			boxed.moveNext();
			//throw new NotImplementedException();
		}

		public Num1 next()
		{
			return nilnul.obj.stream_._slider.CursorX.Next(this);
			//throw new NotImplementedException();
		}
	}
}
