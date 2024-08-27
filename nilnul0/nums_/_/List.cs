using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.str_
{
	[Obsolete(nameof(nilnul.nums_.ListOfClass))]
	public class List:List<nilnul.Num1>
	{
		public List(IEnumerable<Num1> nums):base(nums)
		{

		}

		public List():base()
		{

		}
	}
}
