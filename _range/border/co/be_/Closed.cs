using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.border.duo.be_
{
	public class Closed : BeI
	{
		public bool be(Duo obj)
		{
			return obj.lower.openFalseCloseTrue&& obj.upper.openFalseCloseTrue;

			throw new NotImplementedException();
		}
	}
}
