using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.be
{


	public class Vow_ofIn
		:
		nilnul.obj.be.Vow_ofIn< nilnul.Num_ofIn>
		,
		nilnul.num.Vow_ofInI

	{
		public Vow_ofIn(in BeI_ofIn<Num_ofIn> val) : base(val)
		{
		}

		public Vow_ofIn(BeI_ofIn<Num_ofIn> x) : base(x)
		{
		}
	}

}
