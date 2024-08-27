using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.co.convert_
{
	public class Swap : ConvertI

	{
		public Co eval(Co arg)
		{

			return new Co(arg.Item2,arg.Item1);
		}


		static public Swap Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Swap>.Instance;
			}
		}



	}
}
