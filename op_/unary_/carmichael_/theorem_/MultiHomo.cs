using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.op_.unary_.carmichael_.theorem_
{
	/// <summary>
	/// when GCD(m,n) =1
	/// then
	///		Phi(m) * Phi(n) = Phi (mn)
	/// </summary>
	static public   class _MultiHomoOfPrimesX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="x">prime</param>
		/// <param name="y">another prime. The two times each other to get a product</param>
		/// <returns></returns>
		static public BigInteger _Op_assumePrimeMulti(int x, int y)
		{
			return (
				(BigInteger) totient_.theorem_.MultiHomoOfPrimes._Op_assumePrimeMulti(x,y) )
				/
				BigInteger.GreatestCommonDivisor(x,y);
		}
	}
}
