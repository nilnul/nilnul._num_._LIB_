using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.be_.le.vow.ee_
{
	public class LeThree : Ee
	{
		public LeThree():base(3)
		{
		}

		static public LeThree Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<LeThree>.Instance;
			}
		}


	}
}
