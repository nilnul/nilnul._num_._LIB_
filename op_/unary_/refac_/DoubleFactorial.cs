using nilnul.num.natural.func;
using nilnul.num.natural.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.op_.unary_.dblFactorial
{
	static public  class _OfEvenX
	{

		static public BigInteger _assumeEven(BigInteger _positive_even) {
			var half=_positive_even/2;
		
			return PowerOfTwoX._Eval(half) * nilnul.num.op_.unary_.factorial_.Memoize.Singleton._assumeNat(half);
				
			
		
		}
	}
}
