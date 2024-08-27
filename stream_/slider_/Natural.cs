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
	public class Nat
		:
		//nilnul.num.stream_.SliderA
		nilnul.num.stream_.SliderI4
	{
		private nilnul.Num1 _current=0 ;



		public  Num1 current
		{
			 get
			{
				return _current;
			}
			set {
				_current = value;
			}
		}

		static public IEnumerable<N> EnumerateUpB4(N upperBound)
		{


			var t = new Nat();

			while (t.current<upperBound)
			{
				yield return t.current;
				t.moveNext();

			}
			


		}

		public  void moveNext(nilnul.Num1 x)
		{
			_current+=x;
		}

		public  void moveNext()
		{
			_current++;
		}

		public N next()
		{
			return nilnul.obj.stream_._slider.CursorX.Next(this);
			//throw new NotImplementedException();
		}
	}
}
