using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.border;

namespace nilnul.num.co.convert_
{
	public class Sort : ConvertI

	{
		public Co eval(Co arg)
		{

			if (co.be_.Gt.Singleton.be(arg))
			{
				return Swap.Singleton.eval(arg);

			}
			return arg;
			//throw new NotImplementedException();
		}


		public Co eval(Num1 a, Num1 b)
		{
			return eval(new Co(a,b));
			//throw new NotImplementedException();
		}

		static public Sort Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Sort>.Instance;
			}
		}

	}
}
