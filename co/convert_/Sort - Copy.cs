using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.border;

namespace nilnul.num.duo.convert_
{
	public class Sort : ConvertI

	{
		public Duo1 eval(Duo1 arg)
		{

			if (duo.be_.Gt.Singleton.be(arg))
			{
				return Swap.Singleton.eval(arg);

			}
			return arg;
			//throw new NotImplementedException();
		}

		static public readonly Sort Singleton = nilnul.obj.SingletonByDefault<Sort>.Instance;

		public Duo1 eval(Num a, Num b)
		{
			return eval(new Duo1(a,b));
			//throw new NotImplementedException();
		}
	}
}
