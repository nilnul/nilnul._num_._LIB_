using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord
{
	/// <summary>
	/// can be used as the coord in nilnul.mesh
	/// </summary>
	public class Co
		: nilnul.obj.Duo<OrdI1>
	{
		public Co(Num x, Num y):this(
			new Ord1(x), new Ord1(y)
		)
		{
		}
		public Co(Ord1 item1, Ord1 item2) : this((OrdI1)item1,(OrdI1) item2)
		{
		}
		public Co(OrdI1 item1, OrdI1 item2) : base(item1, item2)
		{
		}
	}
}
