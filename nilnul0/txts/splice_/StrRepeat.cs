using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.natural.duo.op
{
	[Obsolete()]
	public partial class StrRepeat
	{
		static public string Eval(string s, int natural) {
			return string.Join("", Enumerable.Repeat(s, natural));
		}
		static public string Eval(string s, BigInteger natural) {

			var r = new StringBuilder();
			for (BigInteger i = 0; i < natural; i++)
			{
				r.Append( s);

				
			}
			return r.ToString();
		}
	}
}
