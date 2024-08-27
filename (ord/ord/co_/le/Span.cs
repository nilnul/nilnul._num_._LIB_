using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.duo_.le
{
	static public class _CountUpCloseX
	{
		static public nilnul.NumI _CountUpClose(OrdI _ordLower, OrdI _ordUpper) {

			return nilnul.num.convert_.Inc.Singleton.convert( 
				nilnul.num.combine_.Minus.Singleton.combine(
					_ordUpper.toNum(), _ordLower.toNum()
				)
				
			);
		}
	}
}
