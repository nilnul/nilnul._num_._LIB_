using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.op_.ternary_
{
	/* Knuth's up-arrow (↑) notation:
a↑b	=	a↑1b	=	ab exponentiation
a↑↑b	=	a↑2b	=	ba tetration
a↑↑↑b	=	a↑3b pentation
a↑↑↑↑b	=	a↑4b hexation
etc.
		*/
	/// <summary>
	/// 0 means multi
	/// 1 means pow
	///		right associative.
	/// </summary>
	///<remarks>
	/// </remarks>

	static public class _KnuthX
	{

	

		public static BigInteger _Op_assumeNats(BigInteger _ord_natural, BigInteger _base_natural, BigInteger _index_natural)
		{
			if (_ord_natural == 0)
			{
				return  _base_natural*_index_natural;

			}

			if (_index_natural == 0)
			{
				return 1;

			}

			return _Op_assumeNats(
				_ord_natural - 1,
				_base_natural,
				_Op_assumeNats(
					_ord_natural,
					_base_natural,
					_index_natural - 1
				)
			);

		}


		public static Num1 Op(NumI1 ord, NumI1 x, NumI1 y)
		{

			return new Num1( _Op_assumeNats(
				(ord.toBigint())
				,
				(x).toBigint()
				,
				(y).toBigint()
			));
		}
	}
}
