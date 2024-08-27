using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;

namespace nilnul.num.op_.unary_
{
	public class Half1 : nilnul.num.op_.UnaryI1
	{


		public Num1 op(Num1 arg)
		{
			return new Num1( arg.en/2 );
		}

		static public Half1 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Half1>.Instance;
			}
		}


	}
}
