using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.combine_
{
	public class Min : nilnul.num.CombineI1, nilnul.obj.CombineI1<nilnul.Num>
	{
		public NumI combine(NumI arg, NumI arg1)
		{
			return new nilnul.Num( 
				BigInteger.Min(
					arg.toBigint()
					,
					arg1.toBigint()
				) 
				
			);
			//throw new NotImplementedException();
		}



		public Num combine(Num arg, Num arg1) {
			return arg <= arg1 ? arg : arg1;
		}

		static public readonly Min Singleton = nilnul.obj.SingletonByDefault<Min>.Instance;

	}
}
