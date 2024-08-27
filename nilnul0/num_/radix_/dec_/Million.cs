using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix_.dec_
{
	/// <summary>
	/// </summary>
	public class Million : Dec1
	{
		public const ulong ULONG =1000_000;

		public Million() : base(
			new _radix.Root(10)._toDigits1(ULONG)
		)
		{
		}
	}





}
