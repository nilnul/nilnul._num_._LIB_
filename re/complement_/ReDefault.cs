using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.re.complement_
{
	public class Default<TRe> :
		nilnul.num.re.Complement
		where TRe: nilnul.obj.ReI<nilnul.NumI1>,new()
		//where TRe : nilnul.num.ReI, new()

	{
		public Default() : base(
			_obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TRe>.Instance
		)
		{
		}


		static public Default<TRe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Default<TRe>>.Instance;
			}
		}

	}
}
