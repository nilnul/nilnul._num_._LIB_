using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.co_.colRow.vow
{
	

	public class En<TVow,TCol,TRow>
		: nilnul.obj.vow.En<co_.ColRow<TCol,TRow>, TVow>
		where TVow : co_.colRow.VowI<TCol,TRow>, new()
		where TCol : OrdI1
		where TRow : OrdI1

	{
		public En(co_.ColRow<TCol,TRow> val) : base(val)
		{
		}
	}

	

}
