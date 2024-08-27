using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.op_.binary;

namespace nilnul.num.stream
{
	public class Cumulus :
		nilnul.obj.stream.Cumulated<Num1, nilnul.num.StreamI6, nilnul.num.op_.BinaryI1, nilnul.num.op_.binary.CumulatorI>
		,
		nilnul.num.stream_.SliderI4
	{
		public Cumulus(StreamI6 val, CumulatorI fold) : base(val, fold)
		{
		}
	}
}
