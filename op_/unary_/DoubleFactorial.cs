using nilnul.num.natural.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.op_.unary_
{
	static public  class _DblFactorialX
	{
	

		static public BigInteger _assumeNum(BigInteger _natural) {

			if (_natural==0)
			{
				return 1;
				
			}
			if (_natural==1)
			{
				return 1;
				
			}
			return _natural * _assumeNum(_natural - 2);

		
		}

		
	}
}
