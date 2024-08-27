using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.re
{
	public class Converse
		: nilnul.obj.re.Converse<nilnul.NumI1>
		,
		nilnul.num.ReI

	{
		public Converse(obj.ReI<NumI1> re) : base(re)
		{

		}
	}
}
