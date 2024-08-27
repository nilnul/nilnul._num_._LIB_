using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix.comp_
{
	/// <summary>
	/// the compared is in fact not num, but quotient in the formal of gits after decimal point.
	/// </summary>

	static public class _AsMantissaX
	{

		/// <summary>
		/// index is the position.
		/// </summary>
		/// <param name="gits"></param>
		/// <param name="gitsRight"></param>
		/// <returns></returns>
		static public int _Comp_assumesSameBasedGits(
			IEnumerator<BigInteger> gits
			,
			IEnumerator<BigInteger> gitsRight
		)
		{

			while (gits.MoveNext())
			{
				if (
					gitsRight.MoveNext()

				)
				{
					var cComp = gits.Current.CompareTo(gitsRight.Current);
					if (cComp != 0)
					{
						return cComp;
					}

				}
				else
				{
					do
						if (gits.Current != 0)
						{
							return 1;
						}
					while (gits.MoveNext());

					return 0;
				}

			}

			while (gitsRight.MoveNext())
			{
				if (gitsRight.Current != 0)
				{
					return -1;
				}
			}
			return 0;

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
		)
		{
			return _Comp_assumesSameBasedGits(
				gits.GetEnumerator()
				,
				gits1.GetEnumerator()
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

		)
		{
			return _Comp_assumesSameBasedGits(
				gits.Select(n => n.eeByRef)
				,
				gits1.Select(n => n.eeByRef)
			);
		}

	}
}
