using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using N = nilnul.Num1;

namespace nilnul.num
{
	public class Co_onInteface:nilnul.obj.Co<NumI1>
	{

		public Co_onInteface(NumI1 num, NumI1 num1):base((num), (num1))
		{
		}

		public Co_onInteface(N a,N b):base(a, b)
		{

		}



		

		public Co_onInteface(BigInteger x, BigInteger y)
			:this(new N(x),new N(y))
		{

		}
	}
}
