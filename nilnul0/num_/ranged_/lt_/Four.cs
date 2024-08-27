using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.ranged_.lt_
{
	public class Four : nilnul.num_.ranged_.Lt
	{
		public Four(Num val) : base(val, new Positive( 4))
		{

		}


		static public implicit operator int(Four four) {
			return (int)four.ed.val;
		}

		static public explicit operator Four(int four) {
			return new Four(new Num( four)
				
				);
		}

	}
}
