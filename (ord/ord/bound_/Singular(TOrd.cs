using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.range_;

namespace nilnul.num.ord.bound_
{
	public class Singular<TOrd>
		: nilnul.num.ord.Bound<TOrd>
		
		where TOrd:nilnul.num.OrdI1
	{


	

		public Singular(TOrd col1):base(col1,col1)
		{
		}

	

	

	
	}
}
