using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.co_.colRow_
{
	
	public class SameType<TCol>
		: nilnul.obj.Duo<TCol>

		where TCol:OrdI1
	{

		public SameType(TCol x, TCol y): base(x, y)
		{
		}


	}



	
}
