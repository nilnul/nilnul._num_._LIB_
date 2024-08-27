using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.be_.le
{
	public class Vow
		:
		nilnul.num.be.Vow_ofIn
	{

		

		public Vow(in nilnul.Num_ofIn upperBound)
			:
		base(
			new nilnul.num.be_.Le(in upperBound)
		)
		{
		}

		public Vow( nilnul.Num_ofIn upperBound)
			:
		base(
			new nilnul.num.be_.Le(in upperBound)
		)
		{
		}

	
	}
}
