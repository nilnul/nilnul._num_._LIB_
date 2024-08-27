using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._num.bigint.vow.ee_
{
	public class VowSingleton_ofIn<TVow> : vow.Ee_ofIn< TVow>
		where TVow
		:
		nilnul.obj.VowI_ofIn<BigInteger>, new()
	{

		public VowSingleton_ofIn(in BigInteger val)
			:
		base(
			in val
			, 
			nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
		)
		{
		}

		
	}
}
