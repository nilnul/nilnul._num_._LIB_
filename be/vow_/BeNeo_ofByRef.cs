using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.be.vow_
{
	public class BeNeo_ofByRef<TBe>
		: nilnul.num.be.Vow_ofByRef
		where TBe: nilnul.obj.BeI1<nilnul.Num_byRef>,new()
	{
		public BeNeo_ofByRef() : base(
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
				)
		{
		}

		static public BeNeo_ofByRef<TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeNeo_ofByRef<TBe>>.Instance;
			}
		}

	}
}
