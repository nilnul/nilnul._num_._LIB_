using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.border._duo_.lower
{
	public class ToClosed
	{
		public border.vow_.close.Ed eval(nilnul.num.Border1 border) {
			if (border.beClose)
			{
				return new vow_.close.Ed(border);
			}
			else
			{
				return new vow_.close.Ed(
					border.mark+1
				);
			}
		}

		public border.vow_.close.Ed eval(nilnul.num.BorderI border) {
			if (border.openFalseCloseTrue)
			{
				return new vow_.close.Ed(border);
			}
			else
			{
				return new vow_.close.Ed(
					border.mark+1
				);
			}
		}


		static public border_.Close Eval(nilnul.num.Border1 border) {
			if (border.beClose)
			{
				return new border_.Close(border.mark);
			}
			else
			{
				return new border_.Close(
					border.mark+1
				);
			}
		}
		static public border_.Close Eval(nilnul.num.BorderI border) {
			if (border.openFalseCloseTrue)
			{
				return new border_.Close(border.mark);
			}
			else
			{
				return new border_.Close(
					border.mark+1
				);
			}
		}




		static public readonly ToClosed Singleton = nilnul.obj.SingletonByDefault<ToClosed>.Instance;

	}
}
