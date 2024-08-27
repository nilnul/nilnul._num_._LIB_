using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.co.be_.le
{
	public class Vow_OnOrd<TCol>
		:be.vow_.BeDefault_OnOrdBe<TCol, Le_OnOrd<TCol>>
		where TCol:nilnul.num.OrdI2

	{

		static public Vow_OnOrd<TCol> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Vow_OnOrd<TCol>>.Instance;
			}
		}

	}


}
