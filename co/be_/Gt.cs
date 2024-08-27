using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.co.be_
{
	public class Gt : nilnul.num.co.BeI
		,
		num.co.Be_ofCoOnInterfaceI
	{
		

		public bool be(Co obj)
		{
			return obj.Item1 > obj.Item2;
		}

		public bool be(Co_onInteface obj)
		{
			return obj.Item1.toBigint().en > obj.Item2.toBigint().en;
		}

		static public Gt Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Gt>.Instance;
			}
		}



	}
}
