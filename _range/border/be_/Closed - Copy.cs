using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.border.be_
{
	public class Closed : nilnul.num.border.BeI
	{
		public bool be(Border1 obj)
		{
			return obj.beClose;
			throw new NotImplementedException();
		}

		public bool be(BorderI obj)
		{
			return obj.openFalseCloseTrue;
			throw new NotImplementedException();
		}

		static public readonly Closed Singleton = nilnul.obj.SingletonByDefault<Closed>.Instance;

	}
}
