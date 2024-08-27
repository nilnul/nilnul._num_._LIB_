using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using System.Numerics;
using nilnul.obj._stream_;

namespace nilnul.num.stream_
{
	public class Positive1
		: nilnul.num.StreamI6
	{
		private BigInteger _index=1 ;
		public nilnul.Num1 next()
		{
			return new Num1( _index++);

			//throw new NotImplementedException();
		}

		

		
	}
}
