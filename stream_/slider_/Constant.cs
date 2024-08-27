using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using nilnul.obj._stream_;
using N = nilnul.Num1;//._num.bigint.be.Natural.Asserted;


namespace nilnul.num.stream_.slider_
{
	public class Constant :
		
		SliderA
	{
		private N _n;

		

		public override Num1 current => _n;

		public Constant(N n)
		{
			_n = n;
		}

		public Constant(uint x):this( new nilnul.Num1( x ))
		{

		}

		public override void moveNext()
		{
		}
	}
}
