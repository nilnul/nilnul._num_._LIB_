using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.co_.colRow_.sameType
{
	
	public interface VowI<TCol>
		:
		nilnul.obj.VowI<nilnul.num.ord.co_.colRow_.SameType<TCol>>
				where TCol : OrdI1

	{
	}
	

}
