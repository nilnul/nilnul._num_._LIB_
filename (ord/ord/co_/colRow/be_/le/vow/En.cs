using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.co_.colRow.be_.le.vow
{
	
	public class ColRow<TCol,TRow> 
		:
		co_.colRow.vow.En<Vow<TCol,TRow>, TCol,TRow>

		where TCol : OrdI1
		where TRow : OrdI1

	{
		public ColRow(co_.ColRow<TCol,TRow> val) : base(val)
		{
		}
	}
	

}
