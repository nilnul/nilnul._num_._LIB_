using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.re
{
	public class Complement
		:
		nilnul.obj.re.Complement<nilnul.NumI1>
		,
		nilnul.num.ReI

	{
		public Complement(obj.ReI<NumI1> re) : base(re)
		{

		}
	}
}
