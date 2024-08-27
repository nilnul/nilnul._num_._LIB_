using nilnul.num.re;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._theorem.conjecture_
{
	public  class FermatLittle
	{
		static public bool _Pred_0nat_1prime(
			BigInteger n
			,
			BigInteger p
		) {
			var modulo = new num.re_.equiv_.Modulo(p);
			return modulo.Re(
				num.op_.binary_._PowX._Op(n,p)
				,
				n

			);

		}

		static public void _Vow_0nat_1prime(
			BigInteger n
			,
			BigInteger p
		) {
			nilnul.bit.vow_.True1.Vow(
				_Pred_0nat_1prime(n,p)
				,
				$"natural:{n}, prime:{p} doesnot obide theorem:{nameof(FermatLittle)}"
			);
		}
	}
}
