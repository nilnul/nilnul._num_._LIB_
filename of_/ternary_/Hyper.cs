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
	/// The next operation beyond tetration is called pentation. Pentation is repeated tetration. You can imagine how big those numbers must be!
	/// with initial; usually this is associative
	///		right associative.
	/// </summary>
	///<remarks>
	///such as tetration (n = 4), pentation (n = 5), hexation (n = 6), etc
	/// </remarks>

	static public class _HyperX
	{

	

		public static BigInteger _Op_assumeNats(BigInteger _ord_natural, BigInteger _base_natural, BigInteger _index_natural)
		{
			if (_ord_natural == 0)
			{
				return  _index_natural+1;

			}

			if (_index_natural == 0)
			{
				if (_ord_natural==1)
				{
					return _base_natural;
				}
				if (_ord_natural==2)
				{
					return 0;
				}
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
