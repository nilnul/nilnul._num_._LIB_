using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.be.vow_
{
	public class BeNeo_ofIn<TBe>
		: nilnul.num.be.Vow_ofIn
		where TBe: nilnul.obj.BeI_ofIn<nilnul.Num_ofIn>,new()
	{
		public BeNeo_ofIn() : base(
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
				)
		{
		}

		static public BeNeo_ofIn<TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeNeo_ofIn<TBe>>.Instance;
			}
		}

	}
}
