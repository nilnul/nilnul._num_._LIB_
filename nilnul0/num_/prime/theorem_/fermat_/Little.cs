using nilnul.num.re;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.plural_.prime.theorem_.fermat_
{
	internal class Little
	{
		/// <summary>
		/// n^p == a (mod p)
		/// </summary>
		/// <param name="p"></param>
		/// <param name="n"></param>
		/// <returns></returns>
		static public bool Predicate(nilnul.num_.plural_.Prime p, nilnul.Num1 n) {

			var congruence = new nilnul.num.re_.equiv_.Modulo(p.ee);
			return congruence.Re(
				nilnul.num.op_.binary_._PowX._Op_0nonneg_1nonneg(
					n.en
					,
					p.ee.en
				)
				,
				n
			);
		}
	}
}
