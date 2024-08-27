using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.co.vow
{
	public class En<TVow>
		: nilnul.obj.vow.En<Co, TVow>
		where TVow : VowI, new()
	{
		public En(Co val) : base(val)
		{
		}
	}
	

}
