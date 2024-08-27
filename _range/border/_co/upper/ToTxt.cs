using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.border._co.upper
{
	public class _ToTxtX
	{

		static public string ToTxt(bool openFalseCloseTrue) {
			return openFalseCloseTrue ? "]" : ")";
		}
		static public string ToTxt(BorderI2 border) {
			return $"{border.mark}{ToTxt(border.openFalseCloseTrue)}";
		}
	}
}
