using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix_.hex
{
	static public class _ParseX
	{
		static public int Parse(string x) {
			return Convert.ToInt32(x, 16);
		}
		static public long Parse4long(string x) {
			return Convert.ToInt64(x, 16);
		}

		static public ulong Parse4ulong(string x) {
			return Convert.ToUInt64(x, 16);
		}

		static public uint Parse4uint(string x) {
			return Convert.ToUInt32(x, 16);
		}



	}
}
