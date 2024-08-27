using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using System.Numerics;

using N = nilnul.NumI;


namespace nilnul.num.stream_
{
	public class Plural
		: nilnul.num.StreamI4
	{
		private BigInteger _index=2 ;
		public N next()
		{
			return new nilnul.Num( _index++);

			//throw new NotImplementedException();
		}
	}
}
