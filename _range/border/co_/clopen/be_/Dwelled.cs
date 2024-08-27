using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.border.co_.clopen.be_
{
	public class Dwelt : BeI
	{
		public bool be(Clopen obj)
		{

			return  obj.lower.mark <obj.upper.mark;
		}



		static public Dwelt Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Dwelt>.Instance;
			}
		}


	}
}
