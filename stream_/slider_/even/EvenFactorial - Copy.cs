using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using System.Numerics;

using N = nilnul.Num;//.bigint.be.Natural.Asserted;


namespace nilnul.num.slider_
{
	/// <summary>
	/// 0!, 2!, 4!
	/// </summary>
	public class EvenFactorial1
		: nilnul.num.SliderI2
	{
		private N _current=1 ;

		public N current
		{
			get
			{
				return  _current;
			}
		}

		private N _index=0;

		public void moveNext()
		{
			_current *= ++_index;
			_current *= ++_index;

		}


	}
}
