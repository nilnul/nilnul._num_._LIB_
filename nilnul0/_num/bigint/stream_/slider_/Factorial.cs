using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._num.bigint.stream_.slider_
{
	public class Factorial : SliderA
	{

		nilnul._num.bigint.stream_.slider_.PositiveNum _positives = new PositiveNum();

		/// <summary>
		/// as integer is immutable, this is safe;
		/// </summary>
		public ref BigInteger indexAhead { get { return ref _positives.current8ref; } }

		BigInteger _current=1;
		public override BigInteger current => _current;

		public override void moveNext()
		{

			_current *= _positives.current8ref;
			_positives.moveNext();
		}
	}
}
