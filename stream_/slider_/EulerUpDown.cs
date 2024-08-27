using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul._slider_;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num.slider_
{
	/// <summary>
	/// the alternating permutation (reversed is counted as the same as the unreversed) . 
	/// 
	/// Same as the Entringer(n,n)
	/// 
	/// 1, 1, 1, 2, 5, 16, 61, 272, 1385, 7936,
	/// </summary>
	static public class _EulerZigZagX
	{
		static public BigInteger _PermutatedAlter_reversedBeEq(BigInteger nPlus_positive)
		{
			if (nPlus_positive <=1)
			{
				return 1;
			}

			BigInteger sum = 0;
			BigInteger n = nPlus_positive - 1;
			for (BigInteger k = 0; k <= n; k++)
			{
				sum += nilnul.num.set.op_._ProductX._Product_recur(
					num.duo.op_._CombinateStatic._Eval(
							n
							,
							k
					)
					,
					_PermutatedAlter_reversedBeEq(k)
					,
					_PermutatedAlter_reversedBeEq(n - k)

				);

			}
			return sum/2 ;
		}
	}
	/// <summary>
	/// </summary>
	public class EulerZigZag : nilnul.slider_.FroFunc<BigInteger>
	{


		public EulerZigZag() : base(_EulerZigZagX._PermutatedAlter_reversedBeEq)
		{
		}
	}
}
