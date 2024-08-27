using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
namespace nilnul.num.__bigint.be
{
	[Obsolete()]
	public  class Positive
	{
		static public bool Eval(BigInteger x) {
			return x > 0;
		}

		public class Be:nilnul.bit.Be<BigInteger>
		{
			public Be()
				:base(Eval)
			{

			}
			
		}

		public class Asserted:
			nilnul.bit.be.Asserted<BigInteger,Be>
		{
			public Asserted(BigInteger x)
				:base(x)
			{

			}

			

			public bool isEven() {
				return val.IsEven;
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
			static public bool operator ==(BigInteger a,Asserted b) {
				return  a == b.val;
			}

			static public bool operator !=(BigInteger a,Asserted b) {
				return  a != b.val;
			}
			static public bool operator ==(Asserted b,BigInteger a) {
				return  a == b.val;
			}
			static public bool operator !=(Asserted b,BigInteger a) {
				return  a != b.val;
			}

			static public bool operator !=(Asserted a,Asserted b) {
				return  a.val != b.val;
			}
			static public bool operator ==(Asserted a,Asserted b) {
				return  a.val == b.val;
			}

	}
	}
}

namespace nilnul.num.natural.__bigint.be
{
	public partial class Positive
	{
		static public bool Eval(BigInteger x) {
			return x > 0;
		}

		public class Be:nilnul.bit.Be<BigInteger>
		{
			public Be()
				:base(Eval)
			{

			}
			
		}

		public class Asserted:
			nilnul.bit.be.Asserted<BigInteger,Be>
		{
			public Asserted(BigInteger x)
				:base(x)
			{

			}

			

			public bool isEven() {
				return val.IsEven;
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

			static public bool operator ==(BigInteger a, Asserted b)
			{
				return a == b.val;
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


		}
	}
}
