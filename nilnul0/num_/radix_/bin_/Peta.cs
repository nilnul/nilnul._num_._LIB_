using nilnul.num_.radix_.binary_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix_.bin_
{
	/// for byte, "KiB", "MiB", "GiB", "TiB", "PiB", "EiB", "ZiB", "YiB" 
	/// <summary>
	/// 2^50
	/// </summary>
	/// 
	public class Peta : Binary1
	{
		static public ulong ULONG = Tera.ULONG * Kilo.INT;
		public Peta() : base(
			new _radix.Root(2)._toDigits1(
				ULONG
				//((BigInteger) binary_.Giga.ULONG) * 1024
			)
		)
		{
		}


	}
}
