using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;

namespace nilnul.num.stream_
{
	public class Squared :

		stream.FroFunc,
		
		StreamI3
	{
		public Squared():base( nilnul.num.op_.Square.Eval)
		{

		}
	}
}
