using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.ord.co_.colRow_;

namespace nilnul.num.ord_.oneBased
{
	
	public class Bound : nilnul.num.ord.Bound<OneBased>
	{
		public Bound(SameType<OneBased> val) : base(val)
		{
		}

		public Bound(OneBased col1, OneBased col2) : base(col1, col2)
		{
		}
	}
}
