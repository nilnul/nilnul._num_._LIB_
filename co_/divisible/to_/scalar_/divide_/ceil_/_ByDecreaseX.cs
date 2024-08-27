﻿using System;
using System.Net;
using nilnul.num.natural.relation;
using N = nilnul._num.bigint.be.Natural.Asserted;
using System.Numerics;

namespace nilnul.num.co_.divisible.to_.scalar_.divide_
{
	public static class _ByDecreaseX
	{

		public static int _Ceil_01positive(int _dividend_natural, int _divisor_positive)
		{
			return (_dividend_natural -1) / _divisor_positive + 1;
		}

		public static int _Ceil_0nonneg_1positive(int _dividend_natural, int _divisor_positive)
		{
			return _dividend_natural == 0 ? 0 : _Ceil_01positive(_dividend_natural, _divisor_positive);
		}
	}
}