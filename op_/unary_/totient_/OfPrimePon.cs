using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.of_.unary_.totient_
{
	internal class _OfPrimePonX
	{
		static public BigInteger _Totient_0primeAsBasis_1pon(int p,int r) {
			if (r==0)
			{
				return 1;
			}
			
			return BigInteger.Pow(p, r-1) * (p-1) ;


		}
	}
}
