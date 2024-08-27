using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.duo.shift
{
	static public class _ContainX
	{
		/// <summary>
		/// an alternative to compute the containness.
		/// </summary>
		/// <param name="shift"></param>
		/// <param name="num"></param>
		/// <returns></returns>
		static public bool Contain(Shift shift, nilnul.Num num) {
			return nilnul.num.duo.shift.re_.DirCompatible.Singleton.re(
				new Shift(shift.begin,num)
				,
				new Shift(num,shift.end)
			);
		}
	}
}
