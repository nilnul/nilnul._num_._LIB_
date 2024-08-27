using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix_.mille.toTxt_
{
	public class Commaed
	{
		static public string ToTxt(int _num) {
			return _num.ToString("n0"); //String.Format("{0:n}", 1234); //Output: 1,234.00			string.Format("{0:n0}", 9876); // no digits after the decimal point. Output: 9,876
		}
	}
}
