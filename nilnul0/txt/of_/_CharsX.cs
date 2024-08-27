using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.txt.of_
{
	static public class _CharsX
	{
		static public string ConcatAsTxt(this IEnumerable<char> chars) {
			return string.Join("",chars);
		}
	}
}
