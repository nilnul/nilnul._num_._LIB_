using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.plural.be.vow_.beDefault
{
	public class Ee<TBe> : plural.vow.ee_.VowDefault<
		 BeDefault<TBe>
	>
		where TBe : nilnul.num_.plural.BeI, new()

	{
		public Ee(Plural1 val) : base(val)
		{
		}
	}
}
