using nilnul.num._bound;
using nilnul.num.co.be_.lt.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.bound_
{

	public class Clopen
		: nilnul.obj.Box1<
			nilnul.num.co.be_.lt.vow.Ee
		>
		,
		nilnul.num.BoundI
	{
		public Clopen(Ee val) : base(val)
		{
		}

		public Lower lower => new Lower(true, boxed.ee.component);

		public Upper upper => new _bound.Upper(false,boxed.ee.component1);
	}
}
