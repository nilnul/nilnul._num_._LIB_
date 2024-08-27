using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using System.Numerics;

using N = nilnul.Num1;//.bigint.be.Natural.Asserted;


namespace nilnul.num.stream_.slider_
{
	/// <summary>
	/// 0!, 2!, 4!
	/// </summary>
	public class EvenFactorial
		: nilnul.num.stream_.SliderA
	{
		private N _current=1 ;

		public override N current
		{
			get
			{
				return  _current;
			}
		}


		private N _index=0;

		public override void moveNext()
		{
			_current *= ++_index;
			_current *= ++_index;

		}

		
	}
}
