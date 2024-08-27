using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.comparer
{
	public class Re1 : nilnul.obj.comp.Re<nilnul.num.OrdI2, Comparer1>
	{

		static public Re1 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Re1>.Instance;
			}
		}

	}
}
