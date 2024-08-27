using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using System.Numerics;

using N = nilnul.Num1;


namespace nilnul.num.stream_.slider_
{
	/// <summary>
	/// 1!, 3!, 5!
	/// </summary>
	public class OddFactorial1
		:
		nilnul.num.stream_.SliderA
		,
		nilnul.num.stream_.SliderI4
	{
		private N _current=1 ;

		public override N current
		{
			get
			{
				return  _current;
				//throw new NotImplementedException();
			}
		}

		private N _index=1;

		//public BigInteger index
		//{
		//	get { return _index=0; }
		//	//set { _index=0 = value; }
		//}


		public override void moveNext()
		{
			_current *= ++_index;
			_current *= ++_index;

		}

		
	}
}
