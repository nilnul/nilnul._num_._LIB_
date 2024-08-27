using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using nilnul.obj._stream_;
using N = nilnul._num.bigint.be.Natural.Asserted;


namespace nilnul.num.stream_
{
	[Obsolete()]
	public class Constant :
		StreamI3
	{
		private N _n;

		public N n
		{
			get { return _n; }
			set { _n = value; }
		}

		public Constant(N n)
		{
			_n = n;
		}

		public Constant(uint x):this( (N) x)
		{

		}
		public N next()
		{
			return _n;
		}

		
	}
}
