using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.stream_.slider_.even
{
	public class Dehead :
		nilnul.obj.stream_.slider.Dehead<nilnul.Num1>
		,
		SliderI4
		,
		nilnul.obj.stream_.slider_._FuncI
	{
		public Dehead():base( new stream_.slider_.Even1())
		{
		}

		public void moveNext(Num1 num)
		{
			((stream_.slider_.Even1)base.boxed).moveNext(num);
			//throw new NotImplementedException();
		}

		public void setIndex(Num1 num)
		{
			((stream_.slider_.Even1)base.boxed).setIndex(num);
			//throw new NotImplementedException();
		}
	}
}
