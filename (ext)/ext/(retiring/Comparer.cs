using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ext_
{
	public class Comparer : IComparer<ExtA>
	{
		public static readonly Comparer Instance = new Comparer();
		public int Compare(ExtA x, ExtA y)
		{
			if (x is Inf)
			{
				if (y is Inf)
				{
					return 0;
				}
				return 1;
			}
			if (y is Inf)
			{
				return -Compare(y, x);
			}
			return nilnul.num.Comparer.Instance.Compare((x as Seed ).val, (y as Seed).val);

			throw new NotImplementedException();
		}
	}
}
