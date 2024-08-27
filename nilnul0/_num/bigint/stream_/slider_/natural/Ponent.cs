using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._num.bigint.stream_.slider_.natural
{
	public class Ponent
		:
		SliderA
	{
		BigInteger _ponent;
		public Ponent( nilnul.Num_ofIn ponent)
		{
			_ponent = ponent;
		}

		public Ponent(in BigInteger ponent):this( Num_ofIn.Of(in ponent))
		{
				
		}

		stream_.slider_.Natural basic = new Natural();

		public override BigInteger current => num.op_.binary_._PowX._Op_0nonneg_1nonneg(
			basic.current8ref, _ponent
		);

		public override void moveNext()
		{
			basic.moveNext();
		}
	}
}
