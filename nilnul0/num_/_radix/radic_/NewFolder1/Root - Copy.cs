using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using nilnul.character.sorted_.alphabet_;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num_._radix
{
	[Obsolete()]
	public  class Root
	{
		private nilnul.num_.Plural _radic;

		public nilnul.num_.Plural radic
		{
			get { return _radic; }
			set { _radic = value; }
		}

		public BigInteger rootAsBigint
		{
			get { return _radic.toBigint(); }
		}




		public Root(nilnul.num_.Plural root)
		{

			_radic = root;

		}

		public Root(int i):this( (Plural)i)
		{

		}

	

		/// <summary>
		/// note the first one is ^root(eg 10)^0. ie, this is little - endian
		/// </summary>
		/// <param name="_num_natural"></param>
		/// <returns></returns>
		public nilnul.nums_.List  _toDigits(BigInteger _num_natural) {

			var r = new nilnul.nums_.List();

			var rootAsBigint = this.rootAsBigint;

			BigInteger remainder;

			while (_num_natural!=0)
			{
				_num_natural=BigInteger.DivRem(_num_natural, rootAsBigint, out remainder);
				
				r.Add( new nilnul.Num( remainder));
			}
			return r;
		}
		public nilnul.num.str_.List  _toDigits1(BigInteger _num_natural) {

			var r = new nilnul.num.str_.List();

			var rootAsBigint = this.rootAsBigint;

			BigInteger remainder;

			while (_num_natural!=0)
			{
				_num_natural=BigInteger.DivRem(_num_natural, rootAsBigint, out remainder);
				
				r.Add( new nilnul.Num1( remainder));
			}
			return r;
		}

		public nilnul.nums_.List  toPositions(nilnul.NumI _num_natural) {

			return _toDigits(_num_natural.toBigint());
		}


	}
}
