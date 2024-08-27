using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.border._co.upper
{
	public class ToOpen
	{

		

		static public border_.Open1 Eval(nilnul.num.Border2 border) {
			if (border.beClose)
			{
				return new border_.Open1(border.mark+1);
			}
			else
			{
				return new border_.Open1(
					border.mark
				);
			}
		}

		static public border_.Open1 Eval(nilnul.num.BorderI2 border) {
			if (border.openFalseCloseTrue)
			{
				return new border_.Open1(border.mark+1);
			}
			else
			{
				return new border_.Open1(
					border.mark
				);
			}
		}


		static public ToOpen Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<ToOpen>.Instance;
			}
		}


	}
}
