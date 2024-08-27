using System.Numerics;

namespace nilnul.num.bigint.be
{
	public partial class Plural
	{
		public class Asserted:
			nilnul.bit.be.Asserted<BigInteger,Be>
		{
			public Asserted(BigInteger x)
				:base(x)
			{

			}

			public override string ToString()
			{
				return val.ToString();
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

			static public implicit operator Natural.Asserted(Asserted b)
			{
				return new Natural.Asserted(b.val);
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

