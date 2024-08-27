using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.co.be.vow_
{
	public class BeDefault<TBe> :
		Vow
		,
		co._vow_.IntsAssumeI
		where TBe : BeI1<Co_onInteface>,new()
	{
		public BeDefault() : base(
			nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
		)
		{
		}


		static public BeDefault<TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeDefault<TBe>>.Instance;
			}
		}

		public void vow_assumeNums(int x, int y)
		{
			vow(
				new Co_onInteface(x, y)
			); ;
			//throw new NotImplementedException();
		}
	}
}
