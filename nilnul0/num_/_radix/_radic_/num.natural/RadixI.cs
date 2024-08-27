using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num
{


	public partial interface RadixI
	{
		[Obsolete("sortedSet doesn't guarantee distinctness")]
		SortedSet<char> digits
		{
			get;
		}
	}
}
