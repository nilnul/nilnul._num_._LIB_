using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.co.be_
{
	public class Eq :
		Be_ofCoOnInterfaceI
		,
		num.co.BeI
	{
		

		public bool be(Duo1 obj)
		{
			return obj.Item1 == obj.Item2;
			//throw new NotImplementedException();
		}

		public bool be(Co_onInteface obj)
		{
			return obj.Item1.toBigint().en == obj.Item2.toBigint().en;

		}

		public bool be(Co obj)
		{
			return obj.Item1 == obj.Item2;

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
