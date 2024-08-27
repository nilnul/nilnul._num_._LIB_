using System;
using System.Collections;
using System.Numerics;
using nilnul._num.bigint.be;

namespace nilnul.num.op_.unary_
{

	public class Inc :
		UnaryOnClassA,

		nilnul.num.op_.UnaryI1
		,
		nilnul.num.op_._unary_.OnIntefaceI
	{
		

		public override Num1 op(Num1 par)
		{

			return new nilnul.Num1(par+1);

		}

		

		static public Inc Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Inc>.Instance;
			}
		}

	}


}
