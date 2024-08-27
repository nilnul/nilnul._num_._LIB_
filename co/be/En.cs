using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.duo.be
{
	public class En<TBe>
		: nilnul.be.Asserted_assertDefaultDiscarded<Duo, TBe>
		where TBe : BeI, new()
	{
		public En(Duo val) : base(val)
		{
		}
	}
}
