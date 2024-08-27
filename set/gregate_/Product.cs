using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.set.op_
{
	static public class _ProductX
	{
		static public BigInteger _Product_recur(IEnumerable<BigInteger> _naturalS) {
			if (_naturalS.Any())
			{
				return _naturalS.First() * _Product_recur(_naturalS.Skip(1));
			}
			return 1;
		}

		static public BigInteger _Product_recur(params BigInteger[] _naturalS) {
			return _Product_recur( _naturalS as IEnumerable<BigInteger>);
		}

	}
}
