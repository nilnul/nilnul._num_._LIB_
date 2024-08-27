using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.algebra_.modulo.theorem_
{
	class Rsa
	{
		public void Vow(
			nilnul.num_.plural_.Prime p
			,
			nilnul.num_.plural_.Prime q
		) {
			var pAsInt = p.toOriginal().en;
			var qAsInt = q.toOriginal().en;

			var n = pAsInt * qAsInt;


			var m = ( pAsInt - 1 ) * (qAsInt-1);


		}
	}
}
