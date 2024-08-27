using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.stream_.slider_.odd
{
	public class Dehead :
		nilnul.obj.stream_.slider.Dehead<nilnul.Num1>
		,
		SliderI4
	{
		public Dehead():base( new slider_.Odd1())
		{

		}
		
	}
}
