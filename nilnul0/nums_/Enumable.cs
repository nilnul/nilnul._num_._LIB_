using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.str_
{
	public class Enumable :
		nilnul.obj.str_.Enumable<nilnul.Num>
		,

		IEnumerable<nilnul.Num>
	{
		public Enumable(IEnumerable<Num> boxed) : base(boxed)
		{
		}
	}
}
