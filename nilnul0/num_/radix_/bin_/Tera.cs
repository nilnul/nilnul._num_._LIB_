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
	/// 2^40
	/// </summary>
	public class Tera : Binary1
	{
		static public ulong ULONG = Giga.ULONG * Kilo.INT;
		public Tera() : base(
			new _radix.Root(2)._toDigits1(
				ULONG
				//((BigInteger) binary_.Giga.ULONG) * 1024
			)
		)
		{
		}


	}
}
