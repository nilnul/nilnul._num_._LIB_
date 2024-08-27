using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord
{
	[Obsolete()]
	public class Comparer : IComparer<nilnul.num.OrdI1>
	{
		public int Compare(OrdI1 x, OrdI1 y)
		{
			return nilnul.num.Comparer2.Singleton.Compare(x.toNum(), y.toNum());

		}

		static public Comparer Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Comparer>.Instance;
			}
		}

	}
}
