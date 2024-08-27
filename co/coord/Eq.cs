using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.duo.coord
{
	public class Eq : IEqualityComparer<Coord>
	{
		public bool Equals(Coord x, Coord y)
		{
			return nilnul.num.duo.Eq.Singleton.Equals(x,y);
			//throw new NotImplementedException();
		}

		public int GetHashCode(Coord obj)
		{
			return nilnul.num.duo.Eq.Singleton.GetHashCode(obj);
			//throw new NotImplementedException();
		}


		static public readonly Eq Singleton = nilnul.obj.SingletonByDefault<Eq>.Instance;

	}
}
