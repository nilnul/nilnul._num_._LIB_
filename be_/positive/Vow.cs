using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.be_.positive
{
	public class Vow:nilnul.num.be.Vow<Positive>
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
