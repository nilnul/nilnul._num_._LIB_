using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.re.converse_
{
	public class ReDefault<TRe> : nilnul.num.re.Converse
		where TRe: nilnul.obj.ReI<nilnul.NumI1>,new()
		//where TRe : nilnul.num.ReI, new()

	{
		public ReDefault() : base(
			_obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TRe>.Instance
		)
		{
		}


		static public ReDefault<TRe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<ReDefault<TRe>>.Instance;
			}
		}

		
	}
}
