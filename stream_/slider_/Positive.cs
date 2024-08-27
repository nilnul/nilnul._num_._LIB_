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
	public class Positive
		:
		nilnul.obj.stream_.SliderA<N>
		,
		nilnul.num.stream_.SliderI4
	{
		private nilnul.Num1 _current=1 ;

		public override nilnul.Num1 current
		{
			get
			{
				return  _current;
				//throw new NotImplementedException();
			}
		}

		public override void moveNext()
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
