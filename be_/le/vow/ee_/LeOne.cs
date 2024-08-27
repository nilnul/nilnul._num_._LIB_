using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.be_.le.vow.ee_
{
	public class LeOne : Ee
	{
		public LeOne():base(1)
		{
		}

		static public LeOne Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<LeOne>.Instance;
			}
		}


	}
}
