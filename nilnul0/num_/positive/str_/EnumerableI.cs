using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.positive.str_
{
	public interface EnumerableI
		:StrI
		,
		IEnumerable<nilnul.num_.Positive>
	{
	}
}
