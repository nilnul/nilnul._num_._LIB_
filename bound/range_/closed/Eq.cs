using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.range_.closed
{
	public class Eq : IEqualityComparer<Closed>
	{
		public bool Equals(Closed x, Closed y)
		{
			return nilnul.num.Eq.Singleton.Equals(x.begin, y.begin)

				&&
				nilnul.num.Eq.Singleton.Equals(x.end, y.end);

			///throw new NotImplementedException();
		}

		public int GetHashCode(Closed obj)
		{
			return nilnul.num.Eq.Singleton.GetHashCode( obj.begin)
				&
				nilnul.num.Eq.Singleton.GetHashCode(obj.end)
			;
			//throw new NotImplementedException();
		}

		static public readonly Eq Singleton = nilnul.obj.SingletonByDefault<Eq>.Instance;

	}
}
