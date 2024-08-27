using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._num.bigint.vow
{
	public class En1<TVow> : nilnul.obj.vow.En<BigInteger, TVow>
		where TVow
		:
		nilnul._num.bigint.VowI, new()
	{
		public En1(BigInteger val) : base(val)
		{
		}

		
	}
}
