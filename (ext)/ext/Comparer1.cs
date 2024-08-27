using System;
using System.Collections.Generic;

namespace nilnul.num.ext_
{
	public class Comparer1 : IComparer<ExtA1>, IComparer<ExtI>
	{
		public static readonly Comparer1 Instance = new Comparer1();

		public int Compare(ExtA1 x, ExtA1 y)
		{
			if (x is Inf1)
			{
				if (y is Inf1)
				{
					return 0;
				}
				return 1;
			}
			if (y is Inf1)
			{
				return -Compare(y, x);
			}
			return nilnul.num.Comparer1.Instance.Compare((x as Basic).val, (y as Basic).val);

			throw new NotImplementedException();
		}

		public int Compare(ExtI x, ExtI y)
		{
			if (x is Inf1)
			{
				if (y is Inf1)
				{
					return 0;
				}
				return 1;
			}
			if (y is Inf1)
			{
				return -Compare(y, x);
			}
			return nilnul.num.Comparer2.Singleton.Compare((x as Basic).val, (y as Basic).val);
		}
	}
}
