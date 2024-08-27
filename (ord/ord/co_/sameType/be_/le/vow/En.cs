using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.co_.colRow_.sameType.be_.le.vow
{
	
	public class En<TCol> : 
		co_.colRow_.sameType.vow.En<Vow<TCol>,TCol>
		where TCol : OrdI1

	{
		public En(co_.colRow_.SameType<TCol> val) : base(val)
		{
		}
	}

}
