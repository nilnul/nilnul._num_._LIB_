using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix
{

	/// <summary>
	/// 
	/// </summary>
	static public class _CompareX
	{

		public static int _Comp_assumesSameBasedGits1HeavyFirst(IEnumerable<(BigInteger, BigInteger)> enumerable)
		{

			return enumerable.Select(
				c=> c.Item1.CompareTo(c.Item2) 
			).FirstOrDefault(r=>r!=0);

		}

		public static int _Comp_assumesSameBasedGits(IEnumerable<(BigInteger, BigInteger)> enumerable)
		{
			return _Comp_assumesSameBasedGits1HeavyFirst(
				enumerable.Reverse()
			);
		}

		/// <summary>
		/// index is the position.
		/// </summary>
		/// <param name="gits"></param>
		/// <param name="gits1"></param>
		/// <returns></returns>
		static public int _Comp_assumesSameBasedGits(
			IEnumerable<BigInteger> gits
			,
			IEnumerable<BigInteger> gits1

		) {
			/// make them same long
			///
			return _Comp_assumesSameBasedGits(
				obj.str.co.op_.unary_._SameLongX.MakeSameLong(gits,gits1)
			);
			
		}

		


		/// <summary>
		/// index is the position.
		/// </summary>
		/// <param name="gits"></param>
		/// <param name="gits1"></param>
		/// <returns></returns>
		static public int _Comp_assumesSameBasedGits(
			IEnumerable<nilnul.Num_ofIn> gits
			,
			IEnumerable<nilnul.Num_ofIn> gits1

		) {
			return _Comp_assumesSameBasedGits(
				gits.Select(n=>n.eeByRef)
				,
				gits1.Select(n=>n.eeByRef)
			);
		}

	}
}
