using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.comparer
{
	[Obsolete()]
	public class Re : nilnul.obj.comp.Re<nilnul.num.OrdI1, Comparer>
	{

		static public Re Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Re>.Instance;
			}
		}

	}
}
