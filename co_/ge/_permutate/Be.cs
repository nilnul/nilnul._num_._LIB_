using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.duo.op_._permutate
{
	public class Ible:BeI
	{
		static public bool Eval(Duo duo) {
			return duo.Item2 <= duo.Item1;
		}

		public bool be(Duo obj)
		{
			return obj.Item1 >= obj.Item2;

			//throw new NotImplementedException();
		}

		public class En : be.En<Ible>
		{
			public En(Duo val) : base(val)
			{

			}
		}
	}
}
