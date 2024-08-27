using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.duo_.ge
{
	/// <summary>
	/// entringe number
	/// </summary>
	static public class _EntringerX
	{
		static public BigInteger _Bigint(BigInteger n, BigInteger _leN) {
			if ( _leN==0)
			{
				return n==0?1:0;
			}
			return _Bigint(n, _leN - 1) + _Bigint(n - 1, n - _leN);
		}

		static public nilnul.Num Num(BigInteger n, BigInteger _leN) {
			
			return new Num( _Bigint(n,_leN));
		}


		static public IEnumerable<nilnul.num.str_.Enumable> _Triangle() {
			for (BigInteger i = 0; ; i++)
			{
				yield return new nilnul.num.str_.Enumable(
					nilnul.num.str_._UpTo._Bigints(i).Select(x =>  Num(i, x))
				);
			}
		}



	}
}
