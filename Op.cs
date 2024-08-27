using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num
{
	/// <summary>
	/// any function that returns a nilnul.Num; the parameter can be tuple of nilnul.Num , or any other type such as a type that is not subtype of nilnul.Num
	/// </summary>
	/// <remarks>
	///	op can be used in expr
	/// </remarks>
	public interface OpI1:nilnul.obj._op_.RetI<nilnul.Num1>
		,
		nilnul.num.IOf
	{
	}
}
