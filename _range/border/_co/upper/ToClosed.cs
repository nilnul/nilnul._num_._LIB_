using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.border._co.upper
{
	public class ToClosed
	{
		static public border_.Close1 Eval(nilnul.num.Border2 border) {
			if (border.beClose)
			{
				return new border_.Close1(border.mark);
			}
			else
			{
				return new border_.Close1(
					border.mark-1
				);
			}
		}
		public border.be_.close.vow.En eval(nilnul.num.Border2 border) {
			if (border.beClose)
			{
				return new be_.close.vow.En(border);
			}
			else
			{
				return new be_.close.vow.En(
					border.mark-1
				);
			}
		}
	}
}
