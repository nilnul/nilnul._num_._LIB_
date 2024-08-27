using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ext_.comparer
{
	[Obsolete()]
	public class Decider:nilnul.comparer.decider_.FroStatic<num.ExtA1,ext_.Comparer1>
	{

		static public readonly Decider Singleton = SingletonByDefault<Decider>.Instance;

	}
}
