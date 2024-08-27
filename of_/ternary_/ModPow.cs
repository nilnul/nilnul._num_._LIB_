using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.of_.ternary_
{
	/// <summary>
	/// in the context of modulo, a pow;
	/// pow in the modulo sense;
	/// </summary>
	/// 
	static public class _ModPowX
	{
		[Obsolete(nameof(BigInteger.ModPow))]
		static public BigInteger ModPow(BigInteger basic,BigInteger ponent, BigInteger modulus) {
			return BigInteger.ModPow(basic, ponent, modulus);
		}
	}
}
