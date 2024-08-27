using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using nilnul.character.sorted_.alphabet_;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num_.plural._radix
{
	public  class Root
	{
		private nilnul.num.vow_.plural.Ed _radic;

		public nilnul.num.vow_.plural.Ed radic
		{
			get { return _radic; }
			set { _radic = value; }
		}

		public BigInteger rootAsBigint
		{
			get { return _radic.toBigint(); }
		}




		public Root(nilnul.num.vow_.plural.Ed root)
		{

			_radic = root;

		}

		public Root(int i):this( new num.vow_.plural.Ed(i))
		{

		}

	

		/// <summary>
		/// note the first one is ^root(eg 10)^0
		/// </summary>
		/// <param name="num"></param>
		/// <returns></returns>
		public List<nilnul.Num>  toRadix(BigInteger num) {



			var r = new List<nilnul.Num>();

			var rootAsBigint = this.rootAsBigint;

			BigInteger remainder;

			while (num!=0)
			{
				num=BigInteger.DivRem(num, rootAsBigint, out remainder);
				
				r.Add( new nilnul.Num( remainder));


			}


			return r;


		
		}

		//private Radix(
		//	Private private_
		//)
		//{
		//	this._digits = private_._digits;
		//}


	



		
	}
}
