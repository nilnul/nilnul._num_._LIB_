using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be_.natural.vow;

namespace nilnul
{
	/// <summary>
	/// make boxed mutable. but due to the immutability of bigint, the immutability of the Num is of no significant performance gain.
	/// </summary>

	[WronglyImplementation("")]
	[Obsolete()]
	public class Num2: nilnul.obj.Box1<BigInteger>, NumI1, IEquatable<Num2>
	{


	

		public BigInteger bigint
		{
			get { return this.boxed; }
			set {
				nilnul._num.bigint.be_.natural.Vow.Singleton.vow(value);
				this.boxed = value;
			}
		}


		public Num2(BigInteger bigint):base(bigint)
		{

		}

		public Num2():this(0)
		{

		}

		public Num2(Num2 num):base(num.boxed)
		{

		}

	

		public Num2(uint uintVal)
			:this((BigInteger)uintVal)
		{
		}
		public Num2(nilnul._num.bigint.be_.natural.vow.En x):this(x.en)
		{
		}

		[Obsolete(nameof(OvInteface))]
		public Num2(NumI1 x):this(x.toBigint())
		{
		}

		public Num2(NumI x):this(x.toBigint())
		{
		}
		public Num2(Num x):this(x.toBigint())
		{
		}

		static public implicit operator BigInteger(Num2 num) {
			return num.boxed;
		}

		static public implicit operator Num2(uint num) {
			return new Num2(num);
		}

		static public implicit operator Num(Num2 num) {
			return new Num( num.boxed);
		}
		//static public explicit operator Num(Num1 num) {
		//	return new Num( num.en);
		//}


		static public implicit operator Num2(Num num) {
			return new Num2(num);
		}

		static public explicit operator Num2(BigInteger bigint) {
			return new Num2(bigint);
		}

		static public explicit operator Num2(int bigint) {
			return new Num2(bigint);
		}


		//from base is not allowed
		static public implicit operator Num2(_num.bigint.be.Natural.Asserted num)
		{
			return num;
		}

		static public nilnul.Num2 OvInteface( nilnul.NumI1 num)
		{
			switch (num)
			{
				case Num2 n:
					return n;
				default:
					return new Num2(num.toBigint());
					break;
			}
		}


		#region re

		static public bool operator ==(Num2 a, Num2 b) {
			return a.boxed==b.boxed;
		}
		static public bool operator ==(Num2 a, uint b) {
			return a.boxed==b;
		}
		static public bool operator ==(Num2 a, int b) {
			return a.boxed==b;
		}

		static public bool operator !=(Num2 a, int b)
		{
			return !(a == b);
		}

		static public bool operator !=(Num2 a, uint b)
		{
			return !(a == b);
		}

		static public bool operator !=(uint b, Num2 a)
		{
			return !(a == b);
		}
		static public bool operator ==(uint b, Num2 a)
		{
			return a.boxed == b;
		}

		static public bool operator !=(Num2 a, Num2 b)
		{
			return !(a == b);
		}
		static public bool operator >=(Num2 a, Num2 b) {
			return a.boxed>=b.boxed;
		}
		static public bool operator >=(Num2 a, uint b) {
			return a.boxed>=b;
		}
		static public bool operator <=(Num2 a, Num2 b) {
			return a.boxed<=b.boxed;
		}
		static public bool operator <=(Num2 a, NumI1 b) {
			return a.boxed<=b.toBigint();
		}
		static public bool operator >=(Num2 a, NumI1 b) {
			return a.boxed>=b.toBigint();
		}

		static public bool operator <=(Num2 a, uint b) {
			return a.boxed<=b;
		}

		static public bool operator >(Num2 a, Num2 b) {
			return a.boxed>b.boxed;
		}
		static public bool operator >(Num2 a, NumI1 b) {
			return a.boxed>b.toBigint();
		}
		static public bool operator <(Num2 a, NumI1 b) {
			return a.boxed<b.toBigint();
		}


		static public bool operator >(Num2 a, uint b) {
			return a.boxed>b;
		}
		static public bool operator <(Num2 a, Num2 b) {
			return a.boxed<b.boxed;
		}
		static public bool operator <(Num2 a, uint b) {
			return a.boxed<b;
		}
		#endregion


		#region op

		#region unary

		static public Num2 operator ++(  Num2 a) {
			
			return new Num2( a.boxed+1 ); /*Because BigInteger objects are immutable, the Increment operator creates a new BigInteger object whose value is one more than the BigInteger object represented by value. Therefore, repeated calls to Increment may be expensive.*/
		}

		static public Num2 operator --(  Num2 a) {
			return new Num2(a.boxed-1);
		}
		#endregion

		static public Num2 operator -(Num2 a, int b) {
			return new Num2(a.boxed-b);
		}


		static public Num2 operator +(Num2 a, int b) {
			return new Num2(a.boxed+b);
		}

		static public Num2 operator +(Num2 a, Num2 b) {
			return new Num2(a.boxed+b.boxed);
		}
		static public Num2 operator *(Num2 a, Num2 b) {
			return new Num2(a.boxed*b.boxed);
		}
		static public Num2 operator %(Num2 a, uint b) {
			return new Num2( a.boxed%b );
		}

		static public BigInteger operator /(Num2 a, int b) {
			return ( a.boxed/b );
		}
		static public Num2 operator /(Num2 a, uint b) {
			return  new Num2 ( a.boxed/b );
		}




		#endregion



		static public Num2 CreateZero() {
			return new Num2();
		}

		static public Num2 CreateOne() {
			return new Num2(1);
		}

		public En toBigint()
		{
			return new En(boxed);
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as Num2);
		}

		public bool Equals(Num2 other)
		{
			return other != null &&
				   boxed.Equals(other.boxed);
		}

		public override int GetHashCode()
		{
			return  boxed.GetHashCode();
		}
	}
}
