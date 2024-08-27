using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.border.vow_.close;
using nilnul.num.border.vow_.open;

namespace nilnul.num.border.duo.vow_.clopen
{
	public class Ed : nilnul.obj.vow.Ed<nilnul.num.border.Duo, nilnul.num.border.duo.be_.clopen.Vow>
	{

		public Ed(Duo val) : base(val)
		{
		}

		public Ed(border.vow_.close.Ed ed1, border.vow_.open.Ed ed2)
			:this(
				new Duo(ed1.ed, ed2.ed) 
			)
		{
		}
	}
}
