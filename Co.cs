using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using N = nilnul.Num1;

namespace nilnul.num
{
	public class Co:nilnul.obj.Co<N>
	{

		public Co(NumI1 num, NumI1 num1):base(new N(num), new N(num1))
		{
		}

		public Co(N a,N b):base(a, b)
		{

		}



		

		public Co(BigInteger x, BigInteger y)
			:this(new N(x),new N(y))
		{

		}
	}
}
