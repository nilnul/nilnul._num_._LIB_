using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.duo.shift._dir.sign.re_
{
	public class Compatible : ReI
	{
		public bool re(Sign a, Sign b)
		{
			if (a== Sign.Zero || b== Sign.Zero)	//zero is compatible with any
			{
				return true;

			}
			return a == b;
			//throw new NotImplementedException();
		}

		static public readonly Compatible Singleton = nilnul.obj.SingletonByDefault<Compatible>.Instance;

	}
}
