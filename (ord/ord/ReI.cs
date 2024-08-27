using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord
{
	public interface ReI<TOrd>:nilnul.obj.ReI<TOrd>
		where TOrd:nilnul.num.OrdI2
	{
	}
}
