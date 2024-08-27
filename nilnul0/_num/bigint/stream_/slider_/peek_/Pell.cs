using System.Numerics;

namespace nilnul._num.bigint.stream_.slider_.peek_
{
	public class Pell
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
			(_current, _ahead) = (_ahead, _current*2 +_ahead );
		}

		
	}


}
