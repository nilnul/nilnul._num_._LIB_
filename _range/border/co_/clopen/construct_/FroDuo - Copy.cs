using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.border.duo_.clopen.construct_
{
	public class FroDuo
	{
		public nilnul.num.border.duo_.Clopen eval(nilnul.num.border.Duo duo) {
			return new border.duo_.Clopen(
				nilnul.num.border._duo_.lower.ToClosed.Eval(duo.lower)
				,
				nilnul.num.border._duo_.upper.ToOpen.Eval(duo.upper)
			);
		}


		static public readonly FroDuo Singleton = nilnul.obj.SingletonByDefault<FroDuo>.Instance;

	}
}
