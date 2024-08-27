using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.combine_
{
	public class Multi : nilnul.num.CombineI
	{
		public NumI eval(NumI arg, NumI arg1)
		{
			return new Num(arg.toBigint()*arg1.toBigint());
			//throw new NotImplementedException();
		}


		static public readonly Multi Singleton = nilnul.obj.SingletonByDefault<Multi>.Instance;

	}
}
