using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.border._duo_.upper
{
	public class ToOpen
	{

		public border.vow_.open.Ed eval(nilnul.num.Border1 border) {
			if (border.beClose)
			{
				return new border.vow_.open.Ed(border.mark+1);
			}
			else
			{
				return new border.vow_.open.Ed(
					border.mark
				);
			}
		}

		static public border_.Open Eval(nilnul.num.Border1 border) {
			if (border.beClose)
			{
				return new border_.Open(border.mark+1);
			}
			else
			{
				return new border_.Open(
					border.mark
				);
			}
		}

		static public border_.Open Eval(nilnul.num.BorderI border) {
			if (border.openFalseCloseTrue)
			{
				return new border_.Open(border.mark+1);
			}
			else
			{
				return new border_.Open(
					border.mark
				);
			}
		}

		static public readonly ToOpen Singleton = nilnul.obj.SingletonByDefault<ToOpen>.Instance;

	}
}
