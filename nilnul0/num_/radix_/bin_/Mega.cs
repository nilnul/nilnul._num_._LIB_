using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix_.binary_
{
	/// <summary>
	/// for byte, "KiB", "MiB", "GiB", "TiB", "PiB", "EiB", "ZiB", "YiB" 
	/// </summary>
	public class Mega : Binary1
	{
		public const int INT32 = 1048576;
		public const int INT = Kilo.INT * Kilo.INT;

		public Mega() : base(
			new _radix.Root(2)._toDigits1(INT32)
		)
		{
		}


	}
}
