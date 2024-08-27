using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.co.be_.eq
{
	public class Vow:nilnul.num.co.be.vow_.BeDefault<co.be_.Eq>
		,
		co._vow_.IntsAssumeI
	{
		

		public void vow_assumeNums(int x, int y)
		{
			this.vow(
				new Co_onInteface(x,y)
			);
		}


		static public Vow Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Vow>.Instance;
			}
		}

	}
}
