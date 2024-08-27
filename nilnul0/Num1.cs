using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be_.natural.vow;

namespace nilnul
{
	[Obsolete(nameof(Num_ofIn))]
	public class Num1: _num.bigint.be_.natural.vow.En, NumI1, IEquatable<Num1>
		//,
		//_num_.asInteger_.RetRefI
	{

		public Num1(BigInteger bigint):base(bigint)
		{

		}



		public Num1(Num1 num):base(num.en)
		{

		}

			public Num1():this(0)
		{

		}


		public Num1(uint uintVal)
			:this((BigInteger)uintVal)
		{
		}
		public Num1(nilnul._num.bigint.be_.natural.vow.En x):this(x.en)
		{
		}

		[Obsolete(nameof(OvInteface))]
		public Num1(NumI1 x):this(x.toBigint())
		{
		}

		public Num1(NumI x):this(x.toBigint())
		{
		}
		public Num1(Num x):this(x.toBigint())
		{
		}

		

		static public implicit operator BigInteger(Num1 num) {
			return num.en;
		}

		static public implicit operator Num1(uint num) {
			return new Num1(num);
		}

		static public implicit operator Num(Num1 num) {
			return new Num( num.en);
		}
		//static public explicit operator Num(Num1 num) {
		//	return new Num( num.en);
		//}


		static public implicit operator Num1(Num num) {
			return new Num1(num);
		}

		static public explicit operator Num1(BigInteger bigint) {
			return new Num1(bigint);
		}

		static public explicit operator Num1(int bigint) {
			return new Num1(bigint);
		}


		//from base is not allowed
		static public implicit operator Num1(_num.bigint.be.Natural.Asserted num)
		{
			return num;
		}

		static public nilnul.Num1 OvInteface( nilnul.NumI1 num)
		{
			switch (num)
			{
				case Num1 n:
					return n;
				default:
					return new Num1(num.toBigint());
					break;
			}
		}


		#region re

		static public bool operator ==(Num1 a, Num1 b) {
			return a.en==b.en;
		}
		static public bool operator ==(Num1 a, uint b) {
			return a.en==b;
		}
		static public bool operator ==(Num1 a, int b) {
			return a.en==b;
		}

		static public bool operator !=(Num1 a, int b)
		{
			return !(a == b);
		}

		static public bool operator !=(Num1 a, uint b)
		{
			return !(a == b);
		}

		static public bool operator !=(uint b, Num1 a)
		{
			return !(a == b);
		}
		static public bool operator ==(uint b, Num1 a)
		{
			return a.en == b;
		}

		static public bool operator !=(Num1 a, Num1 b)
		{
			return !(a == b);
		}
		static public bool operator >=(Num1 a, Num1 b) {
			return a.en>=b.en;
		}
		static public bool operator >=(Num1 a, uint b) {
			return a.en>=b;
		}
		static public bool operator <=(Num1 a, Num1 b) {
			return a.en<=b.en;
		}
		static public bool operator <=(Num1 a, NumI1 b) {
			return a.en<=b.toBigint();
		}
		static public bool operator >=(Num1 a, NumI1 b) {
			return a.en>=b.toBigint();
		}

		static public bool operator <=(Num1 a, uint b) {
			return a.en<=b;
		}

		static public bool operator >(Num1 a, Num1 b) {
			return a.en>b.en;
		}
		static public bool operator >(Num1 a, NumI1 b) {
			return a.en>b.toBigint();
		}
		static public bool operator <(Num1 a, NumI1 b) {
			return a.en<b.toBigint();
		}


		static public bool operator >(Num1 a, uint b) {
			return a.en>b;
		}
		static public bool operator <(Num1 a, Num1 b) {
			return a.en<b.en;
		}
		static public bool operator <(Num1 a, uint b) {
			return a.en<b;
		}
		#endregion


		#region op

		#region unary

		static public Num1 operator ++(  Num1 a) {
			
			return a+1; /*Because BigInteger objects are immutable, the Increment operator creates a new BigInteger object whose value is one more than the BigInteger object represented by value. Therefore, repeated calls to Increment may be expensive.*/
		}

		static public Num1 operator --(  Num1 a) {
			return a-1;
		}
		#endregion

		static public Num1 operator -(Num1 a, int b) {
			return new Num1(a.en-b);
		}


		static public Num1 operator +(Num1 a, int b) {
			return new Num1(a.en+b);
		}

		static public Num1 operator +(Num1 a, Num1 b) {
			return new Num1(a.en+b.en);
		}
		static public Num1 operator +(Num1 a, NumI1 b) {
			return new Num1(a.en+b.toBigint());
		}

		static public Num1 operator +(NumI1 a, Num1 b) {
			return b + a;
		}

		static public Num1 operator *(Num1 a, Num1 b) {
			return new Num1(a.en*b.en);
		}
		static public Num1 operator %(Num1 a, uint b) {
			return new Num1( a.en%b );
		}

		static public BigInteger operator /(Num1 a, int b) {
			return ( a.en/b );
		}
		static public Num1 operator /(Num1 a, uint b) {
			return  new Num1 ( a.en/b );
		}




		#endregion



		static public Num1 CreateZero() {
			return new Num1();
		}

		static public Num1 CreateOne() {
			return new Num1(1);
		}

		public En toBigint()
		{
			return this;
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as Num1);
		}

		public bool Equals(Num1 other)
		{
			return other != null &&
				   en.Equals(other.en);
		}

		public override int GetHashCode()
		{
			return  en.GetHashCode();
		}
	}
}
