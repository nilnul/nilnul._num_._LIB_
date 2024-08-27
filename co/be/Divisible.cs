using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num.duo.be
{
	public class Divisible:nilnul.BeI<Duo>
	{
		static public bool Eval(N a, N b) {
			return nilnul.num.be.NonZero.Eval(b);
		}

		static public bool Eval(Duo duo ) {
			return nilnul.num.be.NonZero.Eval(duo.Item2);
		}

		public bool be(Duo obj)
		{
			return Eval(obj);
			throw new NotImplementedException();
		}

		public class Asserted:nilnul.be.Asserted<Duo,Divisible>
		{
			public Asserted(Duo x):base(x)
			{

			}

			public Asserted(N a,N b):this(new Duo(a,b))
			{

			}
		}


	}
}
