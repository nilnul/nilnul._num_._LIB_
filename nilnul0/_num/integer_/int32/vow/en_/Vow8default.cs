using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer_.int32.vow.en_
{
	public class Vow8default<TVow>
		:
		nilnul.num.integer_.int32.vow.En
	where TVow : nilnul.obj.VowI_ofIn<int>, new()
	{
		public Vow8default(in int val) : base(val, 
				 nilnul._obj.typ_._UnisonX<TVow>.Unison
				)
		{
		}

		public Vow8default(int val) : this(in val)
		{
		}

	}
}
