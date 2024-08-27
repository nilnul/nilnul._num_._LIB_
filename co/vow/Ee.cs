using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.co.vow
{
	public class Ee :
		nilnul.obj.vow.Ee1<nilnul.num.Co_onInteface>
		,
		num.CoI
		
	{
		public Ee(Co_onInteface val, VowI2<Co_onInteface> vow) : base(val, vow)
		{
		}

	

		public NumI1 component => boxed.Item1;

		public NumI1 component1 => boxed.Item2;
	}
}
