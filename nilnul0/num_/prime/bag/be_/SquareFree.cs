using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.plural_.prime.bag.be_
{
	public class SqFree : BeI
	{
		public bool be(Bag obj)
		{
			return obj.All(e=>e.Value<=1);
		//	throw new NotImplementedException();
		}

		static public SqFree Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<SqFree>.Instance;
			}
		}

	}
}
