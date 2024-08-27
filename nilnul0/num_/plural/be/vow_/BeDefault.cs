using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.plural.be.vow_
{
	public class BeDefault<TBe> : Vow
		where TBe: plural.BeI,new()
	{
		public BeDefault() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}

		
	}
}
