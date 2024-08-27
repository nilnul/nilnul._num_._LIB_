using System;

namespace nilnul.num_.radix_._bin
{
	static public class _GitX
	{
		public const string Gits = "01";
		static public int GitAsInt(char c) {

			var t= Gits.IndexOf(c);

			if (t<0)
			{
				throw new ArgumentOutOfRangeException($"{c} is not a valid binary digit;");
			}
			return t;
		}
	}
}
