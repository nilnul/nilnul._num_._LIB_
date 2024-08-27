using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.op_.binary_
{
	static public partial class _PowX
	{

		static public BigInteger _Op_basePlural_indexPlural(BigInteger _base_plural, BigInteger _index_plural)
		{
			
			BigInteger remainder;
			var half = BigInteger.DivRem(_index_plural, 2, out remainder);	//>=1;

			var halfPow = _Op_basePlural_indexPositive(_base_plural, half);
			//var halfPowSquared = halfPow * halfPow;

			return remainder == 0 ? halfPow * halfPow : halfPow * halfPow * _base_plural;


		}
	
		static public BigInteger _Op_basePlural_indexPositive(BigInteger _base_plural, BigInteger _index_positive)
		{

			if (_index_positive == 1)
			{
				return _base_plural;
			}
			return _Op_basePlural_indexPlural(_base_plural, _index_positive);
			
		}

		static public BigInteger _Op_basePlural_indexNonNeg(BigInteger _base_plural, BigInteger _index_nonNeg)
		{
			
			if (_index_nonNeg == 0)
			{
				return 1;

			}
		
			return _Op_basePlural_indexPositive(_base_plural, _index_nonNeg);

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="_base_nonNeg"></param>
		/// <param name="_index_nonNeg"></param>
		/// <returns></returns>
		static public BigInteger _Op_0nonneg_1nonneg(BigInteger _base_nonNeg, BigInteger _index_nonNeg)
		{
			if (_base_nonNeg == 0)
			{
				if (_index_nonNeg == 0)
				{
					return 1;// Op_ZeroZero();

				}
				return 0;

			}

			if (_base_nonNeg == 1)
			{
				return 1;

			}

			return _Op_basePlural_indexNonNeg(_base_nonNeg, _index_nonNeg);

			

		}

		[Obsolete(nameof(_Op_0nonneg_1nonneg))]
		static public BigInteger _Op(BigInteger _base_nonNeg, BigInteger _index_nonNeg)
		{
			return _Op_0nonneg_1nonneg(_base_nonNeg, _index_nonNeg);
		}

		static public BigInteger _Op(uint base_, uint index)
		{
			return _Op(base_, (BigInteger)index);
		}
		static public BigInteger _Op(int base_, int index)
		{
			
			return _Op((uint)base_,(uint)index);
		}


	}

}
