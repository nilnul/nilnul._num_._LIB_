using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_
{
	[Obsolete()]
	public class Positive : nilnul._num.bigint.be.Positive1.Asserted
	{

		public Positive(BigInteger x) : base(x)
		{
		}

		public Positive(NumI num):base(num.toBigint())
		{
		}

		public Positive(Num num):base(num.toBigint())
		{
		}

		static public implicit operator Num(Positive x) {
			return new Num( x.val);
		}

		static public implicit operator Positive(Plural x) {
			return new Positive( x);
		}
		static public explicit operator int(Positive x) {
			return (int)( x.val);
		}

		static public explicit operator Positive(int x) {
			return new Positive( x);
		}
		static public Positive  operator ++(Positive x) {
			return new Positive(x.val++);
		}


		static public bool  operator <=(Positive x, Positive y) {
			return x.val<=y.val;
		}
		static public bool  operator >=(Positive x, Positive y) {
			return x.val>=y.val;
		}

		static public nilnul.Num  Decrease(Positive x) {
			return new Num(x.val-1) ;
		}


		static public Positive CreateOne() {
			return new Positive(1);
		}

		


	}
}
