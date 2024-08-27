using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord
{
	[Obsolete()]
	public class Eq : IEqualityComparer<OrdI>
	{
		public bool Equals(OrdI x, OrdI y)
		{
			return nilnul.num.Eq.Singleton.Equals(x.toNum(),y.toNum());
			throw new NotImplementedException();
		}

		public int GetHashCode(OrdI obj)
		{
			return nilnul.num.Eq.Singleton.GetHashCode(obj.toNum());
			throw new NotImplementedException();
		}

		static public readonly Eq Singleton = nilnul.obj.SingletonByDefault<Eq>.Instance;

	}
}
