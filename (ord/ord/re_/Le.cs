using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.re_
{
	public class Le<TOrd> : nilnul.num.ord.ReI<TOrd>
		where TOrd:nilnul.num.OrdI2
	{
		public bool re(TOrd a, TOrd b)
		{
			return a.toNum().toBigint().en<=b.toNum().toBigint();
		}

		static public Le<TOrd> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Le<TOrd>>.Instance;
			}
		}

	}

	public class Le:Le<nilnul.num.OrdI2>
	{


	}
}
