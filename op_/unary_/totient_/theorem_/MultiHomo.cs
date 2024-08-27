using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.op_.unary_.totient_.theorem_
{
	/// <summary>
	/// when GCD(m,n) =1
	/// then
	///		Phi(m) * Phi(n) = Phi (mn)
	/// </summary>
	  class MultiHomoOfPrimes
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="x">prime</param>
		/// <param name="y">another prime. The two times each other to get a product</param>
		/// <returns></returns>
		static public int _Op_assumePrimeMulti(int x, int y)
		{
			return _TotientX.  _Op_assumePrime(x) * _TotientX. _Op_assumePrime(y);
		}
	}
}
