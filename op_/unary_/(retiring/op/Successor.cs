using nilnul.num.natural;
using System;
using System.Net;
using System.Numerics;

namespace nilnul.num.op
{
	public partial class Successor
	{
		static public Natural_bigInteger Eval(Natural_bigInteger augend) {

			return new Natural_bigInteger(augend.val + 1);
		
		}

		static public BigInteger Eval(BigInteger _n) {
			return _n + 1;
		}

		public class Pow
		{
			static public BigInteger Eval(BigInteger _n,BigInteger index) {

				BigInteger r = _n;

				while (index-->0)
				{
					r = Successor.Eval(_n);
				}
				return r;



			}
		}

		
	}
}
