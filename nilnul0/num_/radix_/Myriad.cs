using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix_
{
	public class Myriad:nilnul.num_.Radix
	{
		public Myriad(IEnumerable<Num> digits ):base((Plural)10000, new nums_.List( digits))
		{

		}

		static public explicit operator Myriad(int i)
		{
			return new Myriad(_radix.root_.Myriad.ToDigits(i));
		}



	}
}
