using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.positive
{
	[Obsolete(nameof(nilnul.num.ord_.OneBased))]
	public class Ord :
		nilnul.obj.Box<nilnul.num_.Positive>
		,
		nilnul.num.OrdI
	{
		public Ord(Positive val) : base(val)
		{
		}

		public NumI toNum()
		{

			return new Num(this.boxed.val - 1);
			throw new NotImplementedException();

		}




	}
}
