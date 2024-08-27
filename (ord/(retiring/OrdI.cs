using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using N=nilnul.num.natural.Natural_bigInteger;

namespace nilnul.num
{

	/// <summary>
	/// anything that can map one2one with Num
	/// This is placed as an extension, not subtype, is in that: for one-based ord, the ToString() of it will return 1 and it's toNum will return 0; To clear the confusion, nilnul.num.Ord shall be an ext, not a subtype of num as it changed the supertype's behavior in "ToString()"
	/// </summary>
	/// 
	[Obsolete()]
	public interface OrdI
		:_ord_.ToBaseZeroI
	{
	}
}
