using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.be_.lt
{
	public class Vow
		:nilnul.num.be.VowA
	{

		

		public Vow(nilnul.num_.Positive1 upperBound):base(
			new nilnul.num.be_.Lt(upperBound)
		)
		{
		}

	
	}
}
