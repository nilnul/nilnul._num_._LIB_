using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.op_;
using nilnul.num.op_.binary;

namespace nilnul.num.stream_.slider
{
	public class Subsume
		:
		nilnul.obj.stream_.slider.Subsume<Num1, num.stream_.SliderI4, num.op_.BinaryI1>
		,num.stream_.SliderI4

	{
		public Subsume(SliderI4 val, BinaryI1 op) : base(val, op)
		{
		}
	}

	public class Subsume_opDefault<TOp> : Subsume
		where TOp:nilnul.num.op_.BinaryI1,new()
	{
		public Subsume_opDefault(SliderI4 val) : base(val, nilnul.obj_.singleton_.Lazy<TOp>.Instance)
		{
		}
	}

}
