using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix_.dec.lexer_
{
	static public  class _PaddedX
	{
		/// <summary>
		/// for 0, return "0" or more 0s.
		/// for 1234 and 12, return
		///		1234, or "001234"
		///		1234, or 012, if the width is 3.
		/// </summary>
		/// <param name="num"></param>
		/// <param name="width"></param>
		/// <returns></returns>
		static public string Txt(int num, int width)
		{
			return num.ToString().PadLeft(width,'0') ;
		}

	}
}
