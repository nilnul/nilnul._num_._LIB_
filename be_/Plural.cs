using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.be_
{
	public  class Plural:BeI
	{
		

		public bool be(Num obj)
		{
			return obj.val > 1;
			//throw new NotImplementedException();
		}



		static public readonly Plural Singleton = nilnul.obj.SingletonByDefault<Plural>.Instance;


	}
}
