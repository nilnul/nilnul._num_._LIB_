using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num
{
	/// <summary>
	/// eg:
	///		1-3
	///			which is 1,2,3
	///			used in regex like [a-z]
	///				in regex, we have no notation for nonclosed bound;
	/// </summary>
	/// <remarks>
	/// for discrete ordered set such as <see cref="nilnul.INum"/>, we often use this rather than <see cref="num.IBound"/>, which is often used in continuity such as <see cref="nilnul.num.IReal"/>
	/// </remarks>
	public interface IBetwixt
		:
		nilnul.obj.IRange<INum>
	{
	}
}
