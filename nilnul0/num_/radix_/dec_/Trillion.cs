﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix_.dec_
{
	/// <summary>
	/// </summary>
	public class Trillion : Dec1
	{
		public const ulong ULONG =1000_000_000_000;

		public Trillion() : base(
			new _radix.Root(10)._toDigits1(ULONG)
		)
		{
		}
	}





}