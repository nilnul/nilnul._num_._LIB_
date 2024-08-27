using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using System.Numerics;

using N = nilnul._num.bigint.be.Natural.Asserted;


namespace nilnul.num.slider_
{
	[Obsolete()]
	public class Positive
		: nilnul.num.SliderI
	{
		private nilnul._num.bigint.be.Natural.Asserted _current=1 ;

		public nilnul._num.bigint.be.Natural.Asserted current
		{
			get
			{
				return  _current;
				//throw new NotImplementedException();
			}
		}

		public void moveNext()
		{
			_current++;
		}

		static public IEnumerable<N> EnumerateUpB4(N upperBound)
		{


			var t = new Positive();

			while (t.current<upperBound)
			{
				yield return t.current;
				t.moveNext();

			}
			


		}

	}
}
