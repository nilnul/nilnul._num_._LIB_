using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._num.bigint
{
	public class Eq
		: IEqualityComparer<BigInteger>
	{
		public bool Equals(BigInteger x, BigInteger y)
		{
			return x == y;
//			throw new NotImplementedException();
		}

		public int GetHashCode(BigInteger obj)
		{
			return obj.GetHashCode();
			//throw new NotImplementedException();
		}

		static public Eq Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Eq>.Instance;
			}
		}

	}
}
