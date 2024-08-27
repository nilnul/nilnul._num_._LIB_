using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using nilnul.character.sorted_.alphabet_;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num_._radix
{
	[Obsolete(nameof(Radic))]
	public  class Root1:IRadic
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

		public Root1(nilnul.num_.Plural1 root)
		{

			_radic = root;

		}

		public Root1(int i):this( (Plural1)i)
		{

		}

		public Root1(BigInteger natural):this(new Plural1(natural))
		{
		}

		public nilnul.nums_.ListOfClass  _toPositions_0nonneg(BigInteger _num_natural) {

			var r = new nilnul.nums_.ListOfClass();

			var rootAsBigint = this.rootAsBigint;

			BigInteger remainder;

			while (_num_natural!=0)
			{
				_num_natural=BigInteger.DivRem(_num_natural, rootAsBigint, out remainder);
				
				r.Add( new nilnul.Num1( remainder));
			}
			return r;
		}


		/// <summary>
		/// note the first one is ^root(eg 10)^0. ie, this is little - endian
		/// </summary>
		/// <param name="_num_natural"></param>
		/// <returns></returns>
		///
		[Obsolete(nameof(_toPositions_0nonneg))]
		public nilnul.nums_.ListOfClass  _toPositions(BigInteger _num_natural) {

			return _toPositions_0nonneg(_num_natural);
		}

		public nilnul.nums_.ListOfClass  toPositions(nilnul.NumI1 _num_natural) {

			return _toPositions_0nonneg(_num_natural.toBigint());
		}


		[Obsolete(nameof(_toPositions_0nonneg))]
		public nilnul.nums_.ListOfClass  _toPositions(nilnul.NumI1 _num_natural) {

			return _toPositions(_num_natural.toBigint());
		}

		public nilnul.nums_.ListOfClass  toPositions(nilnul.Num1 _num_natural) {

			return _toPositions_0nonneg(_num_natural.en);
		}

		[Obsolete(nameof(_toPositions_0nonneg))]
		public nilnul.nums_.ListOfClass  _toPositions(nilnul.Num1 _num_natural) {

			return _toPositions(_num_natural.en);
		}


	}
}
