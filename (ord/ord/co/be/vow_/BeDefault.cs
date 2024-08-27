using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.co.be.vow_
{
	public class BeDefault_OnColRowBe<TCol,TRow, TBe>:
		nilnul.obj.be.vow_.BeDefaulted4<Co<TCol,TRow>,TBe>
		,
		nilnul.num.ord.co.VowI<TCol,TRow>

		where TBe:BeI<TCol,TRow>,new()
		where TCol: nilnul.num.OrdI2
		where TRow: nilnul.num.OrdI2

	{
	}

	public class BeDefault_OnOrdBe<TCol, TBe> :
		nilnul.obj.be.vow_.BeDefaulted4<Co<TCol>, TBe>
		,
		nilnul.num.ord.co.VowI<TCol>

		where TBe : BeI<TCol>, new()
		where TCol : nilnul.num.OrdI2

	{
		public void vow(Co<TCol, TCol> obj)
		{
			vow( new Co<TCol>(obj.Item1,obj.Item2) );
		}
	}


}
