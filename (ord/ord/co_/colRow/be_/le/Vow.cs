using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.co_.colRow.be_.le
{
	
	public class Vow<TCol,TRow>
		:
		be.Vow<colRow.be_. Le<TCol,TRow>,TCol,TRow>

		where TCol : OrdI1
		where TRow : OrdI1

	{

		static public Vow<TCol,TRow> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Vow<TCol,TRow>>.Instance;
			}
		}

	}

}
