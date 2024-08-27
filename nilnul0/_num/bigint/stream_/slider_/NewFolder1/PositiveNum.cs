using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.stream_.slider_
{
	/// <summary>
	/// 
	/// </summary>
	/// natural is used in nilnul.num.integer;
	public class PositiveNum
		:
		_SliderA
	{
		BigInteger _current=1;

		public ref BigInteger current8ref { get { return ref _current; } }
		public override BigInteger current => _current;

		public override void moveNext()
		{
			_current++;
		}
	}
}
