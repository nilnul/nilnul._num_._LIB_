using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.border;

using N = nilnul.NumI;


namespace nilnul.num
{
	public interface BoundI
		:
		_bound_.LowerI
		,
		_bound_.UpperI
	{
	}
}
