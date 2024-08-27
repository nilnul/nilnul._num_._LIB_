using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.vow.ee_
{


	public class VowSingleton_ofIn<TVow>
		:
		num.vow.Ee_ofIn
		where TVow:  obj.VowI_ofIn<Num_ofIn>,new()

	{
		public VowSingleton_ofIn(Num_ofIn val)
			:
		base(
			val
			,
			nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
		)
		{
		}
	}

}
