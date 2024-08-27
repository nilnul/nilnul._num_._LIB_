using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.stream_.slider_.odd.to_.each_._dblFactorial
{
	/// <summary>
	/// 1, 1*3, 1*3*5, ... (2n+1)!!, ...
	/// </summary>
	public class Ret
		: nilnul.num.stream_.SliderA
	{
		private BigInteger _current=1;

		nilnul.num.stream_.slider_.Odd1 odd = new Odd1();
		public override Num1 current => new Num1(_current);

		public override void moveNext()
		{
			odd.moveNext();
			_current *= odd.current.en;
		}
	}
}
