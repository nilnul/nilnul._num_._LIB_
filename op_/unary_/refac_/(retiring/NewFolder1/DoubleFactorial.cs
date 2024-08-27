using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.mono.op
{
	[Obsolete()]
	public class DoubleFactorial
	{
		static public BigInteger _Eval(BigInteger _natural) {
			if (_natural==0 || _natural==1)
			{
				return 1;

			}
			return _natural * _Eval(_natural - 2);


		}



	}
}
