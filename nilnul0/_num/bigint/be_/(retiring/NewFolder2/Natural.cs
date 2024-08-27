using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Natural_bigInteger =nilnul._num.bigint.be.Natural.Asserted;



namespace nilnul._num.bigint.be
{
	[Obsolete()]
	public  class Natural
	{
		static public bool Eval(BigInteger bigInt)
		{

			return bigInt >= 0;

		}

	[Obsolete()]
		public class Be : nilnul.bit.Be<BigInteger>
		{
			public Be()
				: base(Eval)
			{

			}

		}
		//[Obsolete("op.Abs.Ed")]
		public class Asserted :
			nilnul.bit.be.Asserted<BigInteger, Be>
		{
			public Asserted(BigInteger bigInt)
				: base(bigInt)
			{


			}

		




			public void half()
			{
				this.valSetter /= 2;

			}

			public Asserted toHalf()
			{
				var r = new Asserted(this);
				r.half();
				return r;
			}


			public const char Symbol_N = 'ℕ';   //0x2115;


			static public readonly Natural_bigInteger Zero = new Natural_bigInteger(0);
			static public readonly Natural_bigInteger One = new Natural_bigInteger(1);

			static public Natural_bigInteger GetZero
			{

				get
				{
					return new Natural_bigInteger(0);
				}

			}
			static public Natural_bigInteger GetZero1()
			{


				return new Natural_bigInteger(0);


			}

			static public Natural_bigInteger NewOne
			{

				get
				{
					return new Natural_bigInteger(1);
				}

			}


		


			public void increase()
			{
				val++;
			}

			

			public Asserted(Natural_bigInteger n)
			:this(n.val)
		{
			}

			public Asserted(uint val)
			{
				this.val = val;
			}

			public Asserted(int val)
			{
				this.val = val;
			}

			public BigInteger toBigInteger()
			{
				return this.val;
			}

			static public implicit operator BigInteger(Natural_bigInteger uinteger)
			{
				return uinteger.val;
			}

			//from derived class not allowed
			//static public implicit operator nilnul.Num(Natural.Asserted uinteger)
			//{
			//	return new Num(uinteger);
			//}


			static public implicit operator Natural_bigInteger(uint uinteger)
			{
				return new Natural_bigInteger(uinteger);
			}


			static public explicit operator long (Natural_bigInteger uinteger)
			{
				return (long)(uinteger.val);
			}

			static public explicit operator int (Natural_bigInteger uinteger)
			{
				return (int)(uinteger.val);
			}

			static public explicit operator Natural_bigInteger(BigInteger integer)
			{
				return new Natural_bigInteger(integer);
			}


			static public explicit operator Natural_bigInteger(int integer)
			{
				return new Natural_bigInteger(integer);
			}



			public override string ToString()
			{
				return this.val.ToString();
			}








			static public Natural_bigInteger operator /(Natural_bigInteger n, Natural_bigInteger i)
			{


				return new Natural_bigInteger(n.val / i.val);

			}

			static public Natural_bigInteger operator /(Natural_bigInteger n, int i)
			{

				return n / new Natural_bigInteger(i);

			}

			static public Natural_bigInteger operator *(Natural_bigInteger a, Natural_bigInteger b)
			{
				return new Natural_bigInteger(a.val * b.val);
			}


			static public Natural_bigInteger operator *(Natural_bigInteger a, int b)
			{
				return new Natural_bigInteger(a.val * b);
			}

			static public Natural_bigInteger operator -(Natural_bigInteger a, Natural_bigInteger b)
			{
				return new Natural_bigInteger(a.val - b.val);
			}

			static public Natural_bigInteger operator -(Natural_bigInteger a, int b)
			{
				return new Natural_bigInteger(a.val - b);
			}
			static public Natural_bigInteger operator +(Natural_bigInteger a, int b)
			{
				return new Natural_bigInteger(a.val + b);
			}

			static public Natural_bigInteger Add(Natural_bigInteger a, Natural_bigInteger b)
			{
				return new Natural_bigInteger(a.val + b.val);
			}
			static public Natural_bigInteger operator +(Natural_bigInteger a, Natural_bigInteger b)
			{
				return new Natural_bigInteger(a.val + b.val);
			}

			static public Natural_bigInteger operator ++(Natural_bigInteger a)
			{
				a.val++;    //a.val=a.val+1
				return a;
				//return new Natural(a.val+1);
			}

			static public Natural_bigInteger operator --(Natural_bigInteger a)
			{
				a.val--;    //a.val=a.val+1
				return a;
				//return new Natural(a.val+1);
			}


			// override object.Equals
			public override bool Equals(object obj)
			{
				//       
				// See the full list of guidelines at
				//   http://go.microsoft.com/fwlink/?LinkID=85237  
				// and also the guidance for operator== at
				//   http://go.microsoft.com/fwlink/?LinkId=85238
				//

				if (obj  is null || !(obj is Natural_bigInteger))
				{
					return false;
				}

				// TODO: write your implementation of Equals() here
				return this.val == ((Natural_bigInteger)obj).val;
			}

			// override object.GetHashCode
			public override int GetHashCode()
			{
				// TODO: write your implementation of GetHashCode() here

				return val.GetHashCode();
			}

			static public bool Equals(Natural_bigInteger a, Natural_bigInteger b)
			{
				return a.val == b.val;

			}

			static public bool operator ==(Natural_bigInteger a, Natural_bigInteger b)
			{

				return a.val == b.val;

			}

			static public bool operator !=(Natural_bigInteger a, Natural_bigInteger b)
			{

				return !(a.val == b.val);

			}

			static public bool operator ==(Natural_bigInteger a, int b)
			{

				return a.val == b;

			}

			static public bool operator !=(Natural_bigInteger a, int b)
			{

				return !(a.val == b);

			}


			static public bool operator >(Natural_bigInteger a, Natural_bigInteger b)
			{

				return a.val > b.val;

			}

			static public bool operator >(Natural_bigInteger a, int b)
			{

				return a.val > b;

			}



			static public bool operator >=(Natural_bigInteger a, Natural_bigInteger b)
			{

				return a.val >= b.val;

			}
			static public bool operator >=(Natural_bigInteger a, int b)
			{

				return a.val >= b;

			}

			static public bool operator <(Natural_bigInteger a, Natural_bigInteger b)
			{

				return a.val < b.val;

			}
			static public bool operator <(Natural_bigInteger a, int b)
			{

				return a.val < b;

			}
			static public bool operator <=(Natural_bigInteger a, Natural_bigInteger b)
			{

				return a.val <= b.val;

			}
			static public bool operator <=(Natural_bigInteger a, int b)
			{

				return a.val <= b;

			}








			public int CompareTo(Natural_bigInteger other)
			{
				return this.val.CompareTo(other.val);
			}

			public bool Equals(Natural_bigInteger other)
			{
				return this.val == other.val;
			}

			public class Eq
				: IEqualityComparer<Natural_bigInteger>
			{

				public bool Equals(Natural_bigInteger x, Natural_bigInteger y)
				{
					return x.val == y.val;
				}

				public int GetHashCode(Natural_bigInteger obj)
				{
					return obj.val.GetHashCode();
					throw new NotImplementedException();
				}
			}


		}
	}
}
