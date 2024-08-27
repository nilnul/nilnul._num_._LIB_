using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.border.duo.be
{
	[Obsolete()]
	public class Vow<TBe>:
		nilnul.obj.be.Vow2<nilnul.num.border.Duo, TBe>
		,
		nilnul.obj.VowI2<Duo>
		,
		nilnul.num.border.duo.VowI
		where TBe:nilnul.num.border.duo.BeI,new()
	{
	}
}
