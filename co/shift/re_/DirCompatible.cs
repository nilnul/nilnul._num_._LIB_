using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.duo.shift.re_
{
	public class DirCompatible : ReI
	{
		public bool re(Shift a, Shift b)
		{
			return shift._dir.sign.re_.Compatible.Singleton.re(a.Dir(), b.Dir());
			//throw new NotImplementedException();
		}

		static public readonly DirCompatible Singleton = nilnul.obj.SingletonByDefault<DirCompatible>.Instance;

	}
}
