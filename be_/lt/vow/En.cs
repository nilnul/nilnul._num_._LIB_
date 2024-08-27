using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.be_.lt.vow
{
	public class En : nilnul.num.vow.En
	{
		public En(Vow vow, Num val) : base(vow, val)
		{
		}
		public En(nilnul.num_.Positive1 upperExclusive, Num val) : this(new Vow(upperExclusive), val)
		{
		}


	}
}
