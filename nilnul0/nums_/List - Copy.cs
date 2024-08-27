using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.str_;

namespace nilnul.nums_
{
	[Obsolete()]
	public class List:List<nilnul.Num>
	{
		public List(IEnumerable<Num> nums):base(nums)
		{

		}

		public List():base()
		{

		}

		public List(num.str_.List list):this(
			list.Select(x=>(Num)x )
		)
		{
		}
	}
}
