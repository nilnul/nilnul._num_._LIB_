using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.plural.cast_
{
	public class Poly
	{
		private nilnul.Num _index;

		public nilnul.Num index
		{
			get { return _index; }
			set { _index = value; }
		}

		public Poly(nilnul.Num index)
		{
			_index = index;
		}


		public nilnul.num_.Positive eval(nilnul.num_.Plural plural) {

			if (_index==0)
			{
				return nilnul.num_.Positive.CreateOne();
			}
			return new Positive( _Eval_basePlural_indexPositive(plural, _index) );
		}

		static public nilnul.num_.Positive Eval(nilnul.num_.Plural plural, nilnul.Num index) {

			if (index==0)
			{
				return nilnul.num_.Positive.CreateOne();

			}
			return new Positive( _Eval_basePlural_indexPositive(plural.ed.val, index) );

		}



		static public BigInteger _Eval_basePlural_indexPositive(BigInteger base_plural, BigInteger index_positive)
		{

			if (index_positive == 1)
			{
				return base_plural;
			}
			BigInteger remainder;
			var half = BigInteger.DivRem(index_positive, 2, out remainder); //>=1;
			var halfPow = _Eval_basePlural_indexPositive(base_plural, half);
			//var halfPowSquared = halfPow * halfPow;
			return remainder == 0 ? halfPow * halfPow : halfPow * halfPow * base_plural;
		}

	}
}
