using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.co_.colRow_.sameType.be_.le
{
	
	public class Vow<TCol>
		:co_.colRow_.sameType.be.Vow<Le<TCol>, TCol>

		where TCol : OrdI1

	{

		static public Vow<TCol> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Vow<TCol>>.Instance;
			}
		}

	}
	

}
