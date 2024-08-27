using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ext_.aggregate_
{
	static public class _MinX
	{
		static public nilnul.num.ExtI Min(IEnumerable<nilnul.num.ExtI> exts) {
			return exts.Aggregate((nilnul.num.ExtI)nilnul.num.ext_.Inf1.Singleton, nilnul.num.ext_.op_.binary_.Min.Singleton.op);
		}
	}
}
