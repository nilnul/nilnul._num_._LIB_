using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num
{
	public interface CastI
	{
	}

	public interface CastI<T>:CastI {
		T cast(nilnul.Num num);
	}
}
