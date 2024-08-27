using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._num.bigint.vow
{
	[Obsolete()]
	public class En<TVow> : nilnul.obj.vow.En<BigInteger, TVow>
		where TVow : nilnul.obj.VowI<BigInteger>, new()
	{
		public En(BigInteger val) : base(val)
		{
		}

		
	}
}
