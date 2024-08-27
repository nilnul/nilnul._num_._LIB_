using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.op_.binary_
{
	public class Max :
		nilnul.num.op_.BinaryOnClassA
		,
		nilnul.num.op_.BinaryI
		,
		nilnul.num.op_.BinaryI1
		,
		nilnul.num.op_._binary_.OnInterfacesI
	{
		static public long Op_assumeNums(long x, long y) {
			return x>= y?x:y;
		}

		public NumI op(NumI arg, NumI arg1)
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


		public Num op(Num arg, Num arg1) {
			return arg >= arg1 ? arg : arg1;
		}

		public override Num1 op(Num1 arg, Num1 arg1)
		{
			return arg >= arg1 ? arg : arg1;
		;
		}

		

		static public Max Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Max>.Instance;
			}
		}

	}
}
