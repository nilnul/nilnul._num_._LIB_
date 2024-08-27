using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.str_;

namespace nilnul.num.accumulate_
{
	static public class _SumX
	{
		static public nilnul.Num Eval(IEnumerable<nilnul.Num> nums) {
			if (nilnul.objs.be_._NoneX.None(nums))
			{

				return (Num)0;
			}

			return nums.First() + Eval( nilnul.objs_.started.demote_._TailX._Eval(nums) );
		}

		static public nilnul.Num1 Eval1(IEnumerable<nilnul.Num1> nums) {
			if (nilnul.objs.be_._NoneX.None(nums))
			{

				return (Num1)0;
			}

			return nums.First() + Eval1( nilnul.objs_.started.demote_._TailX._Eval(nums) );
		}

		public static BigInteger Bigint(IEnumerable<BigInteger> enumerable)
		{
			return enumerable.Aggregate((BigInteger)0, (a, c) => a + c);

		}
	}
}
