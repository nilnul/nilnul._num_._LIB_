using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.duo.convert_
{
	public class Swap : ConvertI

	{
		public Duo1 eval(Duo1 arg)
		{

			return new Duo1(arg.Item2,arg.Item1);
		}


		static public readonly Swap Singleton = nilnul.obj.SingletonByDefault<Swap>.Instance;

	}
}
