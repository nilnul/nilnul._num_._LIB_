using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix.to_
{
	static public class _RegressionsX
	{
		static public Radix1 ToRadix1(this RadixI radix) {
			return new num_.Radix1(
				new num_.Plural(
				radix.radic
				)
				,
				new nilnul.num.str_.List(
					radix.gits.Select(x => new Num1(x.eeByRef))
				)
			);
		}
	
		static public RadixI ToRadixI(this Radix1 radix) {
		return new num_.Radix2(

			radix.root

			,

			radix.digits //.Select(x => new Num1(x.eeByRef))

		); ;
		}
	}

}
