using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.border.co.be
{
	public class Vow<TBe>:
		nilnul.obj.be.Vow2<nilnul.num.border.Co, TBe>
		,
		nilnul.num.border.co.VowI
		where TBe:nilnul.num.border.co.BeI,new()
	{
	}
}
