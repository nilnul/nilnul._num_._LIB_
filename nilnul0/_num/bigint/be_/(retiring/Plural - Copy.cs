using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul._num.bigint.be_
{
	[Obsolete()]
	public class Plural
		:
		nilnul.be.Be_froFunc<BigInteger>
		,
		BeI
	{
		static public bool Eval(BigInteger x)
		{
			return x > 1;
		}


		public Plural()
			: base(Eval)
		{

		}


		public class En :
			nilnul.be.Asserted<BigInteger, Plural>
		{
			public En(BigInteger x)
				: base(x)
			{

			}

			public override string ToString()
			{
				return val.ToString();
			}




			public bool isEven()
			{
				return val.IsEven;
			}

			static public En operator *(En a, En b)
			{
				return new En(a.val * b.val);
			}
			static public BigInteger operator *(En a, BigInteger b)
			{
				return a.val * b;
			}
			static public BigInteger operator *(BigInteger a, En b)
			{
				return a * b.val;
			}
			static public En operator /(En a, En b)
			{
				return new En(a.val / b.val);
			}
			static public BigInteger operator /(BigInteger a, En b)
			{
				return a / b.val;
			}

			static public bool operator ==(BigInteger a, En b)
			{
				return a == b.val;
			}

			static public implicit operator bigint.be.Natural.Asserted(En b)
			{
				return new bigint.be.Natural.Asserted(b.val);
			}


			static public implicit operator BigInteger(En b)
			{
				return b.val;
			}



			static public bool operator !=(BigInteger a, En b)
			{
				return a != b.val;
			}
			static public bool operator ==(En b, BigInteger a)
			{
				return a == b.val;
			}
			static public bool operator !=(En b, BigInteger a)
			{
				return a != b.val;
			}

			static public bool operator !=(En a, En b)
			{
				return a.val != b.val;
			}
			static public bool operator ==(En a, En b)
			{
				return a.val == b.val;
			}


		}
	}
}

