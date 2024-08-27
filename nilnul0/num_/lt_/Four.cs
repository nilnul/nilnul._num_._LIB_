using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.be_.lt;

namespace nilnul.num_.lt_
{
	public class Four : nilnul.num_.Lt
	{
		public Four(Num val) : base( new Positive1( 4),val)
		{

		}

	

		static public implicit operator int(Four four) {
			return (int)four.en.val;
		}

		static public explicit operator Four(int four) {
			return new Four(new Num( four)
				
				);
		}

	}
}
