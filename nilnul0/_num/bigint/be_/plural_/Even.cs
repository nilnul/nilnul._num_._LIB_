using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._num.bigint.be_.plural_
{
	public class Even
		:
		nilnul._num.bigint.BeOfRefI
		
	
	{
		public bool be(ref BigInteger x) {
			return x>=2 && x.IsEven;
		}


		static public Even Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Even>.Instance;
			}
		}

	}
}
