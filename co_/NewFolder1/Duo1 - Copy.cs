using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using N = nilnul.Num;

namespace nilnul.num
{
	[Obsolete()]
	public class Duo1:nilnul.obj.Duo<N>
	{

		public Duo1(NumI num, NumI num1):base(new N(num), new N(num1))
		{
		}

		public Duo1(N a,N b):base(a, b)
		{

		}



		

		public Duo1(BigInteger x, BigInteger y)
			:this(new N(x),new N(y))
		{

		}
	}
}
