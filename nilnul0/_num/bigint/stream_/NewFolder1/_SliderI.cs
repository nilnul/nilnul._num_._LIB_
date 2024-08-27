using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.stream_
{
	public interface _SliderI
		:
		integer._StreamI
		,
		_slider._SkimI

	{

	}

	public abstract class _SliderA
		:
		nilnul.obj.stream_.SliderA<BigInteger>
		,
		_SliderI
	{
		
	}
}
