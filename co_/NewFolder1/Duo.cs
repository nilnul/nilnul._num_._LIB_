using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num
{
	[Obsolete()]
	public class Duo:nilnul.Duo<N>
	{
		public Duo(N a,N b):base(a, b)
		{

		}

		public Duo(BigInteger x, BigInteger y)
			:this(new N(x),new N(y))
		{

		}
	}
}
