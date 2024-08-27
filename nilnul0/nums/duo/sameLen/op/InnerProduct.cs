using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.num.str.duo.sameLen.op
{
	public class InnerProduct
	{
		static public BigInteger _Eval(IEnumerable<BigInteger> a, IEnumerable<BigInteger> b) {
			return a.Zip(b, (x, y) => x * y).Aggregate(
				(BigInteger) 0, 
				(BigInteger c, BigInteger acc)=>acc+c
			);
		}




		static public BigInteger _Eval(
			BigInteger[,] _a
			,
			int row
			,
			BigInteger[,] _b
			,
			int col
		) {

			return _Eval(
				nilnul.collection.matrix.MatrixX.Row(_a, row)
				,
				nilnul.collection.matrix.MatrixX.Column(_b, col)
			);

		}

		
	}
}
