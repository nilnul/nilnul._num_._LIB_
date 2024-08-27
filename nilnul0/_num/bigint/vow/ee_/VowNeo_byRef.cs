using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._num.bigint.vow.ee_
{
	public class VowNeo_byRef<TVow> : vow.Ee_retRef< TVow>
		where TVow
		:
		nilnul.obj.Vow_ofRefI<BigInteger>, new()
	{

		public VowNeo_byRef(ref BigInteger val) : base( ref val, 
			nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
		)
		{
		}

		
	}
}
