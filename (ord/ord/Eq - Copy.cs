using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord
{
	public class Eq1 : IEqualityComparer<OrdI1>
	{
		public bool Equals(OrdI1 x, OrdI1 y)
		{
			return nilnul.num.Eq.Singleton.Equals(x.toNum(),y.toNum());
			throw new NotImplementedException();
		}

		public int GetHashCode(OrdI1 obj)
		{
			return nilnul.num.Eq.Singleton.GetHashCode(obj.toNum());
			throw new NotImplementedException();
		}


		static public Eq1 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq1>.Instance;
			}
		}


	}
}
