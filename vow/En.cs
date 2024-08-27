using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.vow
{
	public abstract class En : nilnul.obj.vow.En<nilnul.Num>
	{
		public En(obj.VowI<Num> vow, Num val) : base(vow, val)
		{
		}

		
	}

	public class En<TVow> : nilnul.obj.vow.En<nilnul.Num, TVow>
		where TVow : VowI, new()
	{
		public En(Num val) : base(val)
		{
		}
	}

}
