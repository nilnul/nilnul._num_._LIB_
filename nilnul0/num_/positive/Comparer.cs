using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.positive
{
	public class Comparer : IComparer<Positive>
	{
		public int Compare(Positive x, Positive y)
		{
			return x.val.CompareTo(y.val);
			throw new NotImplementedException();
		}

		static public readonly Comparer Singleton = nilnul.obj.SingletonByDefault<Comparer>.Instance;

	}
}
