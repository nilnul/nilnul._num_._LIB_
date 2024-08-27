using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix_.binary_.byt
{
	static public class _PhraseX
	{
		public static string AsPaddedBinary(byte byt)
		{
			return Convert.ToString(byt, 2).PadLeft(8, '0');
		}
	}
}
