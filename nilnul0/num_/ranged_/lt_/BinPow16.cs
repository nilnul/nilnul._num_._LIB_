using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.ranged_.lt_
{
	public class BinPow16 : nilnul.num_.ranged_.Lt
	{
		public BinPow16(Num val) 
			:
			base(
				val, 
				
				nilnul.num_.plural.cast_._poly.root_.Bin.Index16
			)
		{

		}

		


		static public implicit operator int(BinPow16 four) {
			return (int)four.ed.val;
		}

		static public explicit operator BinPow16(int four) {
			return new BinPow16(new Num( four)
				
				);
		}

	}
}
