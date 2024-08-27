using nilnul.num.natural;
using nilnul.num.natural.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num.duo.op_
{
	public  class Tetration
		:
		duo.Op1
		,
		
		duo.OpI
	{

		static public BigInteger Eval(BigInteger radic_natural,BigInteger index_natural) {
			if (index_natural==0)
			{
				return 1;

			}


			return Pow.Eval(radic_natural, Eval(radic_natural, index_natural - 1));
		}

		static public N Eval1(N radic,N index) {
			return new N(
				Eval(radic.val,index.val)	
			);
		}



		public Tetration()
			:base(Eval1)
		{


		}

		static public Tetration Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Tetration>.Instance;
			}
		}






	}

}
