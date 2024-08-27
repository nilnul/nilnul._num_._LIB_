using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.vow_.ranged
{
	public class Ed : nilnul.obj.vow.Ed<Num>
	{
		public Ed(Num val, nilnul.num.border.duo.vow_.filled.Ed range) : base(val, 
			new nilnul.num.be_.ranged.Vow(range)
		)
		{
		}
	}
}
