using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using nilnul.obj._stream_;
using N = nilnul.Num1;//._num.bigint.be.Natural.Asserted;


namespace nilnul.num.stream_
{
	public class Constant1 :
		
		StreamI6
	{
		private N _n;

		public N n
		{
			get { return _n; }
			set { _n = value; }
		}

		public Constant1(N n)
		{
			_n = n;
		}

		public Constant1(uint x):this( new nilnul.Num1( x ))
		{

		}


		public N next()
		{
			return _n;
		}

		public void reset()
		{
		}
	}
}
