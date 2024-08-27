using System;

namespace nilnul.num_.radix_._dec
{
	static public class _GitX
	{
		public const string Gits = "0123456789";
		static public int GitAsInt(char c) {
			var t= Gits.IndexOf(c);
			if (t<0)
			{
				throw new ArgumentOutOfRangeException($"{c} is not a digit;");
			}
			return t;
		}
	}
}
