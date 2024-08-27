using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.be_.lt;
using nilnul.num.border.duo.vow_.filled;

namespace nilnul.num_
{
	public class Lt : nilnul.num.be_.lt.vow.En
	{
		public Lt(Vow vow, Num val) : base(vow, val)
		{
		}

		public Lt(Positive1 upperExclusive, Num val) : base(upperExclusive, val)
		{
		}
		public Lt(int upperExclusive, Num val):this(new Positive1(upperExclusive),val)
		{

		}
	}
}
