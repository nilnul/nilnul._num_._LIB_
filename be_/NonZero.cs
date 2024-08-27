using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num.be
{
	public partial class NonZero
	{
		static public bool Eval(N x) {
			return x != 0;
		}

		public class Be:nilnul.bit.Be<N>
		{
			public Be()
				:base(Eval)
			{

			}
			
		}

		public class Asserted:
			nilnul.bit.be.Asserted<N,Be>
		{
			public Asserted(N x)
				:base(x)
			{

			}

			

			public bool isEven() {
				return val.val.IsEven;
			}

			public override string ToString()
			{
				return val.ToString();
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

			static public implicit operator N(Asserted b)
			{
				return new N(b.val);
			}

			static public implicit operator BigInteger(Asserted b)
			{
				return b.val;
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

