using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix_.hex.parse_
{
	static public class _ByNumStyleX
	{
		static public int Parse(string x) {
			return int.Parse(x, System.Globalization.NumberStyles.HexNumber);
		}
	}
}
