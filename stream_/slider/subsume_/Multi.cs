using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.op_;
using nilnul.num.op_.binary;

namespace nilnul.num.stream_.slider.subsume_
{
	public class Multi
		:
		Subsume_opDefault<nilnul.num.op_.binary_.Multi>
	{
		public Multi(SliderI4 val) : base(val)
		{
		}
	}

	public class Multi_froNew<TSlider>
		:
		Multi
		where TSlider: num.stream_.SliderI4,new()
	{
		public Multi_froNew() : base(new TSlider())
		{
		}
	}


}
