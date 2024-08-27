using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._num.bigint.stream_
{
	public interface SliderI
		:
		bigint.StreamI
		,
		_slider.SkidI

	{

	}

	public abstract class SliderA
		:
		nilnul.obj.stream_.SliderA<BigInteger>
		,
		SliderI
	{
		
	}
}
