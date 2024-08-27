using nilnul.num_.plural_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.algebra_.modulo_
{
	class Primary
		: nilnul.obj.Box1<
			nilnul.num_.plural_.PrimeI
		>
	{
		public Primary(PrimeI val) : base(val)
		{
		}

		public Primary(int x):this(new Prime(x) )
		{

		}
	}
}
