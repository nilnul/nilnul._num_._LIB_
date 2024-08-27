using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.plural.be;
using P = nilnul.num_.plural_.Prime;

namespace nilnul.num_.plural_.prime
{
	public class Eq
	 :
		nilnul.obj_.singular.Heir<Eq>,

		IEqualityComparer<P>

	{
		public bool Equals(P x, P y)
		{
			return x.ee == y.ee;
			//throw new NotImplementedException();
		}

		public int GetHashCode(Prime obj)
		{
			return plural.Eq1.Singleton.GetHashCode(obj.ee);
			//obj.ee.GetHashCode();
			//throw new NotImplementedException();
		}
	}
}

