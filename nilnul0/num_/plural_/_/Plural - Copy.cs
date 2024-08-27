using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_
{
	[Obsolete()]
	public class Plural:nilnul.num.vow_.plural.Ed
	{
		public Plural(nilnul.Num num):base(num)
		{

		}

		public Plural(BigInteger num):this(new nilnul.Num(num))
		{

		}

		

		static public explicit operator Plural(int a) {
			return new Plural((nilnul.Num)a);
		}


		static public implicit operator BigInteger(Plural a) {
			return a.ed;
		}

		static public explicit operator long(Plural uinteger)
		{
			return (long)(uinteger.ed);
		}


		static public bool operator ==(Plural a, int b)
		{

			return a.ed == b;

		}

		static public bool operator !=(Plural a, int b)
		{

			return a.ed != b;

		}


	}
}
