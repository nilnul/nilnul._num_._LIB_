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
	///
	[Obsolete(nameof(Natural))]
	public class Num
		: nilnul.num.StreamI3
		
	{
		private BigInteger _index=0 ;
		public N next()
		{
			return new N( _index++);

			//throw new NotImplementedException();
		}

		
	}
}
