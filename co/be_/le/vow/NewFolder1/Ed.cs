using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.duo.be_.le.vow
{
	public class Ed : nilnul.obj.vow.Ed<Duo1, Vow>
	{

		public Ed(Duo1 val) : base(val)
		{
		}

		public Ed(Num small, Num upper):this( new Duo1(small,upper))
		{
		}
	}
}
