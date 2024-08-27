using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.op_.binary;

namespace nilnul.num.stream_.slider
{
	public class Cumulus : nilnul.obj.stream_.slider.Cumulus<Num1, nilnul.num.stream_.SliderI4, nilnul.num.op_.BinaryI1, num.op_.binary.CumulatorI>
	{
		public Cumulus(num.stream_.SliderI4 val, CumulatorI fold) : base(val, fold)
		{
		}
	}
}
