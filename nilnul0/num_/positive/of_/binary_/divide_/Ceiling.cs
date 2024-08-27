using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.positive.of_.binary_.divide_
{
	static public  class _CeilingX
	{
		/// <summary>
		/// the returned is still positive;
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		static public int _DivideCeiling_01positive(int x, int y)
		{
			return (x - 1) / y + 1;

		}
		static public BigInteger _DivideCeiling_01positive(BigInteger x, BigInteger y)
		{
			return (x - 1) / y + 1;

		}


		static public ref_.vowless_.Positive _DivideCeilingAsPositive_01positive(int x, int y)
		{
			 return num_.ref_.vowless_.Positive.Of( _DivideCeiling_01positive( x,y) );

		}
		static public ref_.vowless_.Positive _DivideCeilingAsPositive_01positive(BigInteger x, BigInteger y)
		{
			 return num_.ref_.vowless_.Positive.Of( _DivideCeiling_01positive( x,y) );

		}


		static public ref_.vowless_.Positive DivideCeilingAsPositive(num_.ref_.vowless_.Positive x, num_.ref_.vowless_.Positive y)
		{
			 return _DivideCeilingAsPositive_01positive( x.eeByRef,y.eeByRef);

		}

		public static ref_.vowless_.Positive DivideCeilingAsPositive(int v1, int v2)
		{
			return DivideCeilingAsPositive( num_.ref_.vowless_.Positive.Of(v1),  num_.ref_.vowless_.Positive.Of(v2) );
		}
	}
}
