using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix_.dec_
{
	/// <summary>
	/// </summary>
	public class Hundred : Dec1
	{
		public const ulong ULONG =100;

		public Hundred() : base(
			new _radix.Root(10)._toDigits1(ULONG)
		)
		{
		}
	}



}
