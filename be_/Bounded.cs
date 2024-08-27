using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.be_
{
	public class Bounded 
		: 
		nilnul.obj.Box<nilnul.num.Bound>
		,
		nilnul.num.BeI
	{
		public Bounded(Bound val) : base(val)
		{
		}

		public bool be(Num obj)
		{

			return boxed.contain(obj);
			
			//throw new NotImplementedException();
		}
	}
}
