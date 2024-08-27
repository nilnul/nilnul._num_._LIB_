using System;
using System.Collections;
using System.Numerics;
using nilnul._num.bigint.be;

namespace nilnul.num.convert_
{

	static public  class _TriangularSumX
	{

		static public BigInteger _Eval_byLoop(BigInteger _natural)
		{
			BigInteger r = 0;
			for (BigInteger i =0; i <=_natural;i++ )
			{
				r += i;
			}
			return r;
		}

		static public BigInteger _Eval_recur(this BigInteger _natural)
		{
			if (_natural == 0) return 0;

			return _natural + _Eval_recur(_natural-1);

		}

		
	
		
	}


}
