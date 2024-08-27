using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ext_.duo.be_
{
	public class Nonempty : duo.BeI
	{

		static public readonly Nonempty Singleton = SingletonByDefault<Nonempty>.Instance;

		public bool be(Duo obj)
		{
			return Plural.Singleton.be(obj) || Single.Singleton.be(obj);

			throw new NotImplementedException();
		}
	}
}
