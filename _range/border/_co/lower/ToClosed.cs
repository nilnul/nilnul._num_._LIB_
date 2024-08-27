using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.border._co.lower
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
					border.mark+1
				);
			}
		}
		static public border_.Close1 Eval(nilnul.num.BorderI2 border) {
			if (border.openFalseCloseTrue)
			{
				return new border_.Close1(border.mark);
			}
			else
			{
				return new border_.Close1(
					border.mark+1
				);
			}
		}





		static public ToClosed Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<ToClosed>.Instance;
			}
		}


	}
}
