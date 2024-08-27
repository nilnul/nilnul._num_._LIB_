using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_._bijectiveNum.root_
{
	public class TwentySix:Root
	{
		public TwentySix():base(26)
		{

		}


		static public readonly TwentySix Singleton = nilnul.obj.SingletonByDefault<TwentySix>.Instance;

	}
}
