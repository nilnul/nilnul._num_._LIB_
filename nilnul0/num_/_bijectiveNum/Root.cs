using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using nilnul.character.sorted_.alphabet_;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num_._bijectiveNum
{
	public  class Root
	{
		private nilnul.num_.Positive _radic;

		public nilnul.num_.Positive radic
		{
			get { return _radic; }
			set { _radic = value; }
		}

		public BigInteger rootAsBigint
		{
			get { return _radic.val; }
		}




		public Root(nilnul.num_.Positive root)
		{

			_radic = root;

		}

		public Root(int i):this( (nilnul.num_.Positive)i)
		{

		}

	

		/// <summary>
		/// note the first one is ^root(eg 10)^0. ie, this is little - endian
		/// </summary>
		/// <param name="_num_natural"></param>
		/// <returns></returns>
		public nilnul.num_.positive.str_.EnumerableI  _toDigits(BigInteger _num_natural)
		{

			var r = new List<nilnul.num_.Positive>();


			BigInteger remainder;

			while (_num_natural!=0)
			{

				_num_natural= nilnul.num._Div4RemPositiveX._Div4RemPositive(_num_natural, rootAsBigint, out remainder);
				
				r.Add( new nilnul.num_.Positive( remainder));

			}
			return new nilnul.num_.positive.str_.Enumerable( r);
		}
	}
}
