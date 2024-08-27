using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.str_;

namespace nilnul.nums_
{
	public class ListOfClass:List<nilnul.Num1>
	{
		public ListOfClass(IEnumerable<Num1> nums):base(nums)
		{

		}

		public ListOfClass():this( new Num1[0])
		{

		}
		public ListOfClass(IEnumerable<BigInteger> nums):this(nums.Select(i=>new Num1(i)))
		{

		}

		public ListOfClass(IEnumerable<int> nums):this(nums.Select(i=>new Num1(i)))
		{

		}

	}
}
