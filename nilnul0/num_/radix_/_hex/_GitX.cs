using System;

namespace nilnul.num_.radix_._hex
{
	static public class _GitX
	{
		public const string Gits = _dec._GitX.Gits + "abcdef";
		static public int GitAsInt(char c) {

			var t= Gits.IndexOf(c);

			if (t<0)
			{
				throw new ArgumentOutOfRangeException($"{c} is not a valid hex digit;");
			}
			return t;
		}
	}
}
