using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.duo.shift
{
	static public class _DirX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="shift"></param>
		/// <returns></returns>
		static public _dir.Sign Dir(this Shift shift) {

			var compared = nilnul.num.Comparer1.Instance.Compare(shift.begin,shift.end);
			
			if (compared<0)
			{
				return _dir.Sign.Positive;
			}
			else if (compared==0)
			{
				return _dir.Sign.Zero;
			}
			return _dir.Sign.Negative;
		}
	}
}
