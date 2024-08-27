using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.border.co.vow
{
	public class En<TVow> :
		nilnul.obj.vow.En<nilnul.num.border.Co, TVow>
		where TVow : nilnul.num.border.co.VowI, new()
	{
		public En(Co val) : base(val)
		{
		}
	}
}
