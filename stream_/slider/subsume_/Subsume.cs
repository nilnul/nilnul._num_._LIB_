using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.op_;
using nilnul.num.op_.binary;

namespace nilnul.num.stream_.slider.subsume_
{
	public class Add
		:
		Subsume_opDefault<nilnul.num.op_.binary_.Add>
	{
		public Add(SliderI4 val) : base(val)
		{
		}
	}
	public class Add_froNew<TSlider>
	:
	Add
	where TSlider : num.stream_.SliderI4, new()
	{
		public Add_froNew() : base(new TSlider())
		{
		}
	}
}
