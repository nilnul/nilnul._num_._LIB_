using System;
using System.Collections;
using System.Numerics;
using nilnul._num.bigint.be;

namespace nilnul.num.op_.unary_
{
	static public  class _FactorialX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_natural"></param>
		/// <returns></returns>
		///
		static public BigInteger _ByLoop_assumeNat(BigInteger _natural)
		{
			BigInteger r = 1;
			for (BigInteger i =_natural; i >1;i-- )
			{
				r *= i;
			}
			return r;
		}


		[Obsolete()]

		static public BigInteger _Op_byLoop(BigInteger _natural)
		{
			return _ByLoop_assumeNat(_natural);
		}


		static public BigInteger _Op_recur(this BigInteger _natural)
		{
			if (_natural == 0) return 1;
			return _natural * _Op_recur(_natural-1);
		}
	}

	
}