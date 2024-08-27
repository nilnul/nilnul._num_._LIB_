using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.re_
{
	public class Gt<TOrd> : nilnul.num.ord.ReI<TOrd>
		where TOrd:nilnul.num.OrdI2
	{
		public bool re(TOrd a, TOrd b)
		{
			return a.toNum().toBigint().en>b.toNum().toBigint();
		}

		static public Gt<TOrd> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Gt<TOrd>>.Instance;
			}
		}

	}
}
