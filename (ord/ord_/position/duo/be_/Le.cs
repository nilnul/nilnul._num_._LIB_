using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.positive.ord.duo.be_
{
	public class Le : BeI
	{
		public bool be(Duo obj)
		{
			return nilnul.num_.positive.comp.Re.Singleton.le(obj.Item1, obj.Item2);
			throw new NotImplementedException();
		}

		static public readonly Le Singleton = nilnul.obj.SingletonByDefault<Le>.Instance;

	}
}
