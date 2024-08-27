using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.border.duo.vow
{
	public class En<TVow> :
		nilnul.obj.vow.En<nilnul.num.border.Duo, TVow>
		where TVow : nilnul.num.border.duo.VowI, new()
	{
		public En(Duo val) : base(val)
		{
		}
	}
}
