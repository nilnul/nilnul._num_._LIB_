using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num.duo.op_
{
    static public class _GcdX
    {
		static public int Gcd(int a, int b) {
			return a == 0 ? b : Gcd(b % a, a);
		}
		/// <summary>
		/// if both are zero, return zero.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		static public N Gcd(N x, N y) {
			return (N)BigInteger.GreatestCommonDivisor(x.val, y.val);	//if both are zero, return zero.
		}
    }
}
