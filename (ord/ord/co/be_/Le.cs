using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.co.be_
{
	public class Le_OnOrd<TOrd> : ord.co.BeA_OnTOrd<TOrd>
		where TOrd:nilnul.num.OrdI2
	{
		public override bool be(Co<TOrd> obj)
		{
			return nilnul.num.ord.re_.Le<TOrd>.Singleton.re(obj.Item1, obj.Item2);

			//throw new NotImplementedException();
		}

		

		static public Le_OnOrd<TOrd> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Le_OnOrd<TOrd>>.Instance;
			}
		}

	}


}
