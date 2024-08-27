using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.border.duo_.clopen.be_
{
	public class Dwelled : BeI
	{
		public bool be(Clopen obj)
		{

			return  obj.lower.mark <obj.upper.mark;
			throw new NotImplementedException();
		}


		static public readonly Dwelled Singleton = nilnul.obj.SingletonByDefault<Dwelled>.Instance;

	}
}
