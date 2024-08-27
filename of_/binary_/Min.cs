using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.op_.binary_
{
	public class Min : nilnul.num.op_.BinaryByIntegerA

	{
		public NumI op(NumI arg, NumI arg1)
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



		public Num op(Num arg, Num arg1) {
			return arg <= arg1 ? arg : arg1;
		}

		public override BigInteger op(BigInteger par, BigInteger par1)
		{
			return par <= par1 ? par : par1;
			//throw new NotImplementedException();
		}

		static public Min Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Min>.Instance;
			}
		}

	}
}
