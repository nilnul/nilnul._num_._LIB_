using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.co_.colRow_
{
	[Obsolete(nameof(ord.Co<TCol>))]
	public class SameType1<TCol>
		: nilnul.num.ord.Co<TCol>

		where TCol:OrdI2
	{

		public SameType1(TCol x, TCol y): base(x, y)
		{
		}


	}



	
}
