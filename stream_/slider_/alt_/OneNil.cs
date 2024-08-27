using nilnul.bit.stream_.slider_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.stream_.slider_.alt_
{
	/// <summary>
	/// map nilnul.bit.stream_.Alt into the realm of num, with 1 as the head
	/// 1,0,1,0,
	/// </summary>
	/// <remarks>
	/// </remarks>
	public class OneNil :
		nilnul.obj.Box1<nilnul.bit.stream_.slider_.alter_.OneNil>
		,
		nilnul.num.stream_.SliderI4
		,
		nilnul._obj.typ_.nilable_.unprimable_.INotSingularable
	{
		public OneNil() : base(new bit.stream_.slider_.alter_.OneNil())
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
