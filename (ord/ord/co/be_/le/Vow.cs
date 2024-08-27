using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.co.be_.le
{
	public class Vow
		:be.Vow<Le>
	{

		static public Vow Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Vow>.Instance;
			}
		}

	}


}
