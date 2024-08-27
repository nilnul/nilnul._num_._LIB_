using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.co_.colRow_.sameType.be
{
	

	
	public class Vow<TBe,TCol>
		:
		nilnul.obj.be.Vow2<co_.colRow_.SameType<TCol>,TBe>
		,
		nilnul.num.ord.co_.colRow_.sameType.VowI<TCol>

		where TBe:co_.colRow_.sameType. BeI<TCol>,new()

		where TCol : OrdI1

	{
	}


}
