using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.natural.op


{
	static public partial class MultiplyX 
    {
		static public Natural2 Multiply(this Natural2 a, Natural2 b)
		{
			return op.Multiply.Exec(a, b);
		}

		static public class Pow
		{
			static public BigInteger Eval(BigInteger _base, BigInteger index_natural) {
				BigInteger r = 1;
				while (index_natural-->0)
				{
					r *= _base;
				}
				return r;
			}
		}


		

		
        
    }
	
}
