using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.positive.stream_.slider_._canon_.by_
{
	public class ByBigint
		:
		nilnul._num.bigint.stream_.SliderA
	{
		private I _current=1;

	

		public override I current => _current;

		public override void moveNext()
		{
			_current++;
		}
	}
}
