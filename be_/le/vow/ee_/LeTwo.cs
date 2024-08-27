using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.be_.le.vow.ee_
{
	public class LeTwo : Ee
	{
		public LeTwo():base(2)
		{
		}

		static public LeTwo Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<LeTwo>.Instance;
			}
		}


	}
}
