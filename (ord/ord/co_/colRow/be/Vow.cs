using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.co_.colRow.be
{
	

	public class Vow<TBe,TCol,TRow>:

		nilnul.obj.be.Vow2< co_.ColRow<TCol,TRow>,TBe>
		,
		nilnul.num.ord.co_.colRow.VowI<TCol,TRow>

		where TBe:colRow.BeI<TCol,TRow>,new()
		where TCol : OrdI1
		where TRow : OrdI1

	{
	}
	


}
