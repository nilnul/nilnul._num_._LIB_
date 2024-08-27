using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.vow.ee_
{


	public class VowNeo<TVow>
		:
		num.vow.Ee_byRef
		where TVow:  VowI2<Num_byRef>,new()

	{
		public VowNeo(Num_byRef val) : base(val,
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
		)
		{
		}
	}

}
