using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;

namespace nilnul.num.duo.op_._combi
{
	public class Be
		: duo.BeI
	{
		public bool be(Duo obj)
		{
			return obj.Item1 >= obj.Item2;
			throw new NotImplementedException();
		}

		public class En : nilnul.be.Asserted_assertDefaultDiscarded<Duo, Be>
		{
			

			public En(Duo val) : base(val)
			{
			}

			public En(Natural.Asserted a, Natural.Asserted b)
				:this( new Duo(a,b))
			{
				
			}
		}
	}
}
