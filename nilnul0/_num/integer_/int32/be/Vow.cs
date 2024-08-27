using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer_.int32.be
{
	public class Vow
		: nilnul.obj.be.Vow_ofIn<int>
	{
		public Vow(in BeI_ofIn<int> val) : base(val)
		{
		}

		public Vow(BeI_ofIn<int> x) : base(x)
		{
		}
	}
}
