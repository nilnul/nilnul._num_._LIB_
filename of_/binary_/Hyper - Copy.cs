using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.op
{
	[Obsolete()]
	public partial class Hyper
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="n_theOrder"></param>
		/// <param name="base_natural"></param>
		/// <param name="index_natural"></param>
		/// <returns></returns>
		public static BigInteger Eval_0multi(BigInteger n_theOrder, BigInteger base_natural, BigInteger index_natural) {
			if (n_theOrder==0)
			{
				return  base_natural * index_natural;
				
				
			}

			if (index_natural==0)
			{
				return 1;

			}
			return Eval_0multi(n_theOrder - 1, base_natural, Eval_0multi(n_theOrder,base_natural,index_natural-1) );
		
		}

		

		


	}
}
