using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
namespace nilnul._num.bigint.be
{
	public  class Positive1:BeI<BigInteger>
	{
		

		public bool be(BigInteger obj)
		{
			return obj > 0;

			throw new NotImplementedException();
		}

		

		public class Asserted:
			nilnul.be.Asserted<BigInteger,Positive1>
		{
			public Asserted(BigInteger x)
				:base(x)
			{

			}

			

			public bool isEven() {
				return val.IsEven;
			}

			public override string ToString()
			{
				return val.ToString();
			}
			static public Asserted operator +(Asserted a, Asserted b)
			{
				return new Asserted(a.val + b.val);
			}

			static public Asserted operator *(Asserted a,Asserted b) {
				return new Asserted( a.val * b.val);
			}
			static public BigInteger operator *(Asserted a,BigInteger b) {
				return  a.val * b;
			}
			static public BigInteger operator *(BigInteger a,Asserted b) {
				return  a * b.val;
			}

			

			static public Asserted operator /(Asserted a,Asserted b) {
				return new Asserted( a.val / b.val);
			}
			static public BigInteger operator /(BigInteger a,Asserted b) {
				return  a / b.val;
			}

			static public BigInteger operator /(Asserted a1, BigInteger b) {
				return   a1.val/b;
			}

			static public BigInteger operator %(Asserted a1, BigInteger b) {
				return   a1.val%b;
			}

			static public bool operator ==(BigInteger a, Asserted b)
			{
				return a == b.val;
			}

			static public implicit operator Natural.Asserted(Asserted b)
			{
				return new Natural.Asserted(b.val);
			}

			static public implicit operator BigInteger(Asserted b)
			{
				return b.val;
			}

			static public bool operator >(Asserted a, uint b)
			{
				return a.val > b;
			}

			static public bool operator >(Asserted a, Asserted b)
			{
				return a.val > b;
			}

			static public bool operator <(Asserted a, Asserted b)
			{
				return a.val < b;
			}

			static public bool operator <(Asserted a, uint b)
			{
				return a.val< b;
			}
			static public bool operator !=(BigInteger a, Asserted b)
			{
				return a != b.val;
			}
			static public bool operator ==(Asserted b, BigInteger a)
			{
				return a == b.val;
			}
			static public bool operator !=(Asserted b, BigInteger a)
			{
				return a != b.val;
			}

			static public bool operator !=(Asserted a, Asserted b)
			{
				return a.val != b.val;
			}
			static public bool operator ==(Asserted a, Asserted b)
			{
				return a.val == b.val;
			}

			public static explicit operator Asserted(int v)
			{
				return new Asserted(v);
				throw new NotImplementedException();
			}
		}
	}
}

