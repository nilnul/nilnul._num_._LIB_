using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.vow_.plural
{
	public class Ed:nilnul.obj.vow.Ed<nilnul.Num, nilnul.num.be_.plural.Vow>
	{
		public Ed(nilnul.Num num):base(num)
		{

		}

		public Ed(int i):this(new Num(i))
		{

		}

		public BigInteger toBigint() {
			return this.ed.val;

		}
	}
}
