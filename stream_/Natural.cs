using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using System.Numerics;

using N = nilnul._num.bigint.be.Natural.Asserted;
using nilnul.obj._stream_;

namespace nilnul.num.stream_
{
	/// <summary>
	/// 0,1,2,3
	/// </summary>
	public class Natural
		:
		nilnul.num.StreamI6
	{
		private BigInteger _index=0 ;

		public Num1 next()
		{
			return new Num1( _index++ );
		}
	}
}
