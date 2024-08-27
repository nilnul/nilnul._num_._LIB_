using System.Linq;
using System.Numerics;


namespace nilnul.num_.radix.of_.unary_
{
	static public class _PrependNilsX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="radix">little1st</param>
		/// <param name="prependings">as heavy gits;</param>
		/// <returns></returns>
		static public num_.Radix2 __PrependNils_1nonneg(num_.RadixI radix, int prependings)
		{
			return new nilnul.num_.Radix2(
				radix.radic
				,
				radix.gits.Select(
					x => (x.eeByRef)
				).Concat(
					Enumerable.Repeat(
						BigInteger.Zero, prependings
					)
				)   //note:here the gits is little1st;
			);
		}
		static public num_.Radix2 __PrependNils_1nonneg(num_.RadixI radix, BigInteger prependings)
		{
			return __PrependNils_1nonneg(radix, (int)prependings);
		}

		static public num_.RadixI _PrependNils_1nil0pos(num_.RadixI radix, int prependings)
		{
			if (prependings == 0)
			{
				return radix;
			}
			return __PrependNils_1nonneg(radix, prependings);
		}

		static public num_.RadixI _PrependNils_1nil0pos(num_.RadixI radix, BigInteger prependings)
		{
			return _PrependNils_1nil0pos(radix, (int)prependings);
		}
	}
}