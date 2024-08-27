using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.border.be_
{
	public class Closed1 : nilnul.num.border.BeI1
	{
		public bool be(Border2 obj)
		{
			return obj.openFalseCloseTrue;
			throw new NotImplementedException();
		}

		public bool be(BorderI2 obj)
		{
			return obj.openFalseCloseTrue;
			throw new NotImplementedException();
		}


		static public Closed1 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Closed1>.Instance;
			}
		}

	}
}
