using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.border.co_.clopen.construct_
{
	public class FroCo
	{
		public nilnul.num.border.co_.Clopen eval(nilnul.num.border.Co duo) {
			return new border.co_.Clopen(
				nilnul.num.border._co.lower.ToClosed.Eval(duo.lower)
				,
				nilnul.num.border._co.upper.ToOpen.Eval(duo.upper)
			);
		}



		static public FroCo Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<FroCo>.Instance;
			}
		}


	}
}
