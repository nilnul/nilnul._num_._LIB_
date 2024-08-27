using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._num
{
	/// <summary>
	/// previousely, <see cref="System.Numerics.BigInteger"/> is not in runtime, and we use array to implement bignum;
	/// now that the system provides bigint, we will hence base our num on that;
	/// </summary>
	/// <remarks>
	/// later, we will have nilnul.num.integer prj;
	/// shall here we name some types, such stream, related to bigint as nilnul.num.integer？
	///		If we allow that, then in nilnul.num.integer, we can reuse it; but the cons is in theory, nilnul.num.integer shall be a derived prj from nilnul.num;
	///		if we dont allow that, we may define such as nilnul._num.integer, and in nilnul.num.integer, we can still reuse it; the cons is we may need to subtype it in order to introduce them into namespace of nilnul.num.integer.;
	/// </remarks>
	internal class IInteger
	{
	}
}
