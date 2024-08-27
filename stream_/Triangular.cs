using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using nilnul.num._num.bigint.be;
using nilnul.num.type._stream;
using nilnul._num.bigint.be;
using nilnul._stream_;

namespace nilnul.num.stream_
{
	public class Triangular
		: nilnul.num.StreamI4
	{
		private BigInteger _n;

		public BigInteger n
		{
			get { return _n; }
			//set { _n = value; }
		}


		public NumI next()
		{

			return new nilnul.Num(
				nilnul.num.convert_._TriangularSumX._Eval_byLoop(_n++)
			);
			//throw new NotImplementedException();
		}
		public void reset()
		{
			_n = 0;
			//throw new NotImplementedException();
		}


	}
}
