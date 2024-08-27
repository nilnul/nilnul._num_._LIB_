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
	public class Giga : Binary1
	{
		public const ulong ULONG = 1048576 *1024;
		public const int INT = Kilo.INT * Mega.INT;

		/// <summary>
		/// 
		/// </summary>
		public const long LONG =
			Kilo.INT * Mega.INT	//1k * 1m = 2^30 le int.max=2^31-1
		;


		public Giga() : base(
			new _radix.Root(2)._toDigits1(ULONG)
		)
		{
		}


	}
}
