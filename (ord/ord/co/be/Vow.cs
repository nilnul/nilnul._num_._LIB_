using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.co.be
{
	public class Vow<TBe>:
		nilnul.obj.be.Vow2<Co,TBe>
		,
		nilnul.num.ord.co.VowI
		where TBe:BeI,new()
	{
	}


}
