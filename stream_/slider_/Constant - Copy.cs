using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using nilnul.obj._stream_;
using N = nilnul.NumI1;//._num.bigint.be.Natural.Asserted;


namespace nilnul.num.slider_
{
	public class Constant :
		
		SliderI3
	{
		private N _n;

		public N n
		{
			get { return _n; }
			set { _n = value; }
		}

		public NumI1 current => _n;

		public Constant(N n)
		{
			_n = n;
		}

		public Constant(uint x):this( new nilnul.Num1( x ))
		{

		}

		public void moveNext()
		{
		}
	}
}
