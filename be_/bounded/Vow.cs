using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.be_.bounded
{
	public class Vow
		:nilnul.num.be.VowA
	{
		

		public Vow(nilnul.num.Bound _range):base(
			new nilnul.num.be_.Bounded(_range)
		)
		{
		}

	
	}
}
