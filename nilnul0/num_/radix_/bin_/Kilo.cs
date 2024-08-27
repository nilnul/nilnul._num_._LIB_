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
	public class Kilo : Binary1
	{
		public const uint UINT = 1024;
		public const int INT = 1024;
		public Kilo() : base(
			new _radix.Root(2)._toDigits1(UINT)
		)
		{
		}

	}
}
