using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.stream_.slider_.peek_
{
	public class Fibonacci
		:
		nilnul.obj.stream_.SliderA<BigInteger>
		,
		nilnul.obj.stream_.slider_.IPreview
		,
		nilnul.obj.stream_.SliderI<BigInteger>
		,
		PeekI
	{
		private BigInteger _current = 0;
		private BigInteger _ahead = 1;

		public override BigInteger current => _current;

		public BigInteger ahead =>_ahead;

		public override void moveNext()
		{
			(_current, _ahead) = (_ahead, _current+_ahead );
		}

		
	}


}
