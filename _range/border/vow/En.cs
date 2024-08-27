using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.border.vow
{
	public class En<TVow> : nilnul.obj.vow.En<nilnul.num.BorderI2, TVow>
		where TVow : nilnul.num.border.VowI, new()
	{
		public En(BorderI2 val) : base(val)
		{
		}
	}
}
