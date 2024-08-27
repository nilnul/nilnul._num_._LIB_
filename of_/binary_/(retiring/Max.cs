using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.combine_
{
	[Obsolete(nameof(op_.binary_.Max))]
	public class Max : nilnul.num.CombineI1, nilnul.obj.CombineI1<nilnul.Num>
	{
		public NumI combine(NumI arg, NumI arg1)
		{
			return new nilnul.Num( 
				BigInteger.Max(
					arg.toBigint()
					,
					arg1.toBigint()
				) 
				
			);
			//throw new NotImplementedException();
		}



		public Num combine(Num arg, Num arg1) {
			return arg >= arg1 ? arg : arg1;
		}

		static public readonly Max Singleton = nilnul.obj.SingletonByDefault<Max>.Instance;

	}
}
