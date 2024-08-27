using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord
{
	public class Comparer1 : IComparer<nilnul.num.OrdI2>
	{
		public int Compare(OrdI2 x, OrdI2 y)
		{
			return nilnul.num.Comparer2.Singleton.Compare(x.toNum(), y.toNum());

		}

		static public Comparer1 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Comparer1>.Instance;
			}
		}

	}
}
