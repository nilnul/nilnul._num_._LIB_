using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord
{
	public class Eq2 : IEqualityComparer<OrdI2>
	{
		public bool Equals(OrdI2 x, OrdI2 y)
		{
			return nilnul.num.Eq.Singleton.Equals(x.toNum(),y.toNum());
			throw new NotImplementedException();
		}

		public int GetHashCode(OrdI2 obj)
		{
			return nilnul.num.Eq.Singleton.GetHashCode(obj.toNum());
			throw new NotImplementedException();
		}


		static public Eq2 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq2>.Instance;
			}
		}


	}
}
