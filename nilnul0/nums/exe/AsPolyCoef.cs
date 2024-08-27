using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.str.exe
{
	public class AsPolyCoef
	{
		static public BigInteger Eval(BigInteger _n, params BigInteger[] coefs) {

			var powed = BigInteger.One;
			var r = BigInteger.Zero;

			foreach (var item in coefs)
			{
				r += item * powed;
				powed *= _n;
			}

			return r;
			
		}
	}
}
