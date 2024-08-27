using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.plural_.prime.bag.trich_
{
	public class Mobius : nilnul.obj.SignI<Bag>
	{

		static public Mobius Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Mobius>.Instance;
			}
		}

		public bool? sign(Bag obj)
		{
			var squareFree = be_.SqFree.Singleton.be(obj);
			if (squareFree)
			{
				return obj
			}
			else
			{
				return null;
			}
			//throw new NotImplementedException();
		}
	}
}
