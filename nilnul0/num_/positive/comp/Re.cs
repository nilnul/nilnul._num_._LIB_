using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.positive.comp
{
	public class Re
		:nilnul.obj.comp.Re<Positive,Comparer>
	{

		static public readonly Re Singleton = nilnul.obj.SingletonByDefault<Re>.Instance;

	}
}
