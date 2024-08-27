using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord
{
	public class Duo
		: nilnul.obj.Duo<OrdI>

	{

		public Duo(NumI x, NumI y):this(
			new Ord(x), new Ord(y)
		)
		{
		}

		public Duo(OrdI item1, OrdI item2) : base(item1, item2)
		{
		}
	}
}
