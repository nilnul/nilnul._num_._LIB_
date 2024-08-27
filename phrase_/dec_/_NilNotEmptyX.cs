using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.phrase_.dec_
{
	static public class _NilNotEmptyX
	{
		/// <summary>
		/// zero is a str of zeros but not empty
		/// </summary>
		/// <param name="num"></param>
		/// <returns></returns>
		static public string Phrase(nilnul.Num num) {
			var r=_DecX.Phrase(num);
			return r == "" ? "0" : r;
		}

	}
}
