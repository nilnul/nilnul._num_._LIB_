using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_
{
	[Obsolete(nameof(num_.ref_.vowless_.Plural) + " is more performant")]

	public class Plural1 :
		nilnul._num.bigint.be_.plural.vow.En
	{
		public Plural1(BigInteger num):base(num)
		{

		}
		public Plural1(nilnul.Num1 num):base(num.en)
		{

		}
		public Plural1(nilnul.num_.Positive1 x):base(x.en)
		{

		}


		static public explicit operator Plural1(int a) {
			return new Plural1(a);
		}


		static public implicit operator BigInteger(Plural1 a) {
			return a.en;
		}
		static public implicit operator Num1(Plural1 a) {
			return new Num1(a.en);
		}

		static public explicit operator Plural1(Num1 a) {
			return new Plural1(a);
		}

		static public explicit operator long(Plural1 uinteger)
		{
			return (long)(uinteger.en);
		}


		static public bool operator ==(Plural1 a, int b)
		{

			return a.en == b;

		}

		static public bool operator ==(Plural1 a, Plural1 b)
		{

			return a.en == b.en;

		}
		static public bool operator !=(Plural1 a, Plural1 b)
		{

			return ! (a==b );

		}

		static public bool operator !=(Plural1 a, int b)
		{

			return a.en != b;

		}


	}
}
