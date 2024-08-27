using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Numerics;
using nilnul._num.bigint.be;

namespace nilnul.num.op_.unary_.factorial_
{
	 public  class Memoize: UnaryI1
	{
		ConcurrentDictionary<BigInteger, BigInteger> cache = new ConcurrentDictionary<BigInteger, BigInteger>();

		 BigInteger _recurOnCache( BigInteger _natural)
		{

			if (_natural == 0) return 1;
			return _natural * _assumeNat(_natural-1);
		}
		public BigInteger _assumeNat( BigInteger _natural)
		{
			return cache.GetOrAdd(_natural,  _recurOnCache );
		}

		public Num1 op(Num1 par)
		{
			return new Num1( _assumeNat(par.en) );
		}


		static public Memoize Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Memoize>.Instance;
			}
		}

	}

}