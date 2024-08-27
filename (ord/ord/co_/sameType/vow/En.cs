using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.co_.colRow_.sameType.vow
{
	


	public class En<TVow,TCol>
		: nilnul.obj.vow.En<co_.colRow_.SameType<TCol>, TVow>
		where TVow : co_.colRow_.sameType.VowI<TCol>, new()
		where TCol : OrdI1

	{
		public En(co_.colRow_.SameType<TCol> val) : base(val)
		{
		}
	}

}
