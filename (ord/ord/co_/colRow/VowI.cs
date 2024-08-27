using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.co_.colRow
{
	

	public interface VowI<TCol,TRow>:nilnul.obj.VowI<nilnul.num.ord.co_.ColRow<TCol,TRow>>
				where TCol : OrdI1
		where TRow : OrdI1

	{
	}

}
