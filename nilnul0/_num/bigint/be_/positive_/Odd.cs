using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._num.bigint.be_.positive_
{
	public class Odd
		:
		nilnul._num.bigint.BeOfRefI
		
	
	{
		public bool be(ref BigInteger x) {
			return x>=1 && !x.IsEven;
		}


		static public Odd Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Odd>.Instance;
			}
		}

	}
}
