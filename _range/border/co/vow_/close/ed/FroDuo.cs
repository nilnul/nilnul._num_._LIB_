using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.border.duo.vow_.close.ed
{
	public class FroDuo
	{
		public nilnul.num.border.duo.vow_.close.Ed eval(Duo duo) {
			return new nilnul.num.border.duo.vow_.close.Ed(
				nilnul.num.border._duo_.lower.ToClosed.Singleton.eval(duo.lower)
				,
				nilnul.num.border._duo_.lower.ToClosed.Singleton.eval(duo.upper)

			);

		}


		static public readonly FroDuo Singleton = nilnul.obj.SingletonByDefault<FroDuo>.Instance;

	}
}
