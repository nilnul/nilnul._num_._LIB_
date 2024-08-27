using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using nilnul.character.sorted_.alphabet_;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num_._radix
{
	public  class Radic:IRadic
		,
		_radic_.CountI
	{
		private nilnul.num_.Plural1 _radic;

		public nilnul.num_.Plural1 radic
		{
			get { return _radic; }
			set { _radic = value; }
		}

		public BigInteger rootAsBigint
		{
			get { return _radic.en; }
		}

		public int count => (int)_radic.en;

		public Radic(nilnul.num_.Plural1 root)
		{

			_radic = root;

		}

		public Radic(int i):this( (Plural1)i)
		{

		}

		public Radic(BigInteger natural):this(new Plural1(natural))
		{
		}

		public IEnumerable<BigInteger>  _toPositions_0nonneg(BigInteger _num_natural) {

			var rootAsBigint = this.rootAsBigint;

			BigInteger remainder;

			while (_num_natural!=0)
			{
				_num_natural=BigInteger.DivRem(_num_natural, rootAsBigint, out remainder);
				
				yield return  remainder;
			}
		}


		


	}
}
