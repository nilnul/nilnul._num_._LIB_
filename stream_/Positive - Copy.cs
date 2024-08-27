using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using System.Numerics;
using N = nilnul._num.bigint.be.Natural.Asserted;



namespace nilnul.num.stream_
{
	public class Positive
		: nilnul.num.StreamI3
	{
		private BigInteger _index=1 ;
		public N next()
		{
			return new N( _index++);

			//throw new NotImplementedException();
		}
	}
}
