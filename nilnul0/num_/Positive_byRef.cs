using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be_.natural.vow;

namespace nilnul.num_
{
	/// <summary>
	/// </summary>

	[Obsolete(nameof(num_.ref_.vowless_.Positive) + " is more performant")]
	public class Positive_byRef: nilnul._num.bigint.be_.positive.vow.Ee_byRef, NumI1, IEquatable<Positive_byRef>
	{


		public ref BigInteger bigint
		{
			get { return ref this.eeByRef; }
			
		}


		public Positive_byRef(ref BigInteger bigint):base(ref bigint)
		{

		}

		public Positive_byRef( BigInteger bigint):this(ref bigint)
		{

		}

		public Positive_byRef(uint uintVal)
			:this((BigInteger)uintVal)
		{
		}
		public Positive_byRef():this(1)
		{

		}


	

		public Positive_byRef(nilnul._num.bigint.be_.natural.vow.En x):this(x.en)
		{
		}

		

		public Positive_byRef(NumI x):this(x.toBigint())
		{
		}
		public Positive_byRef(Num x):this(x.toBigint())
		{
		}

		static public implicit operator BigInteger(Positive_byRef num) {
			return num.eeByRef;
		}

		static public explicit operator Positive_byRef(uint num) {
			return new Positive_byRef(num);
		}

		static public implicit operator Num(Positive_byRef num) {
			return new Num( num.eeByRef);
		}
		//static public explicit operator Num(Num1 num) {
		//	return new Num( num.en);
		//}


		static public explicit operator Positive_byRef(Num num) {
			return new Positive_byRef(num);
		}

		static public explicit operator Positive_byRef(BigInteger bigint) {
			return new Positive_byRef(bigint);
		}

		static public explicit operator Positive_byRef(int bigint) {
			return new Positive_byRef(bigint);
		}


		//from base is not allowed
		static public explicit operator Positive_byRef(_num.bigint.be.Natural.Asserted num)
		{
			return new Positive_byRef(num);
		}

		static public nilnul.num_.Positive_byRef OvInteface( nilnul.NumI1 num)
		{
			switch (num)
			{
				case Positive_byRef n:
					return n;
				default:
					return new Positive_byRef(num.toBigint());
					break;
			}
		}


		#region re

		static public bool operator ==(Positive_byRef a, Positive_byRef b) {
			return a.eeByRef ==b.eeByRef;
		}
		static public bool operator ==(Positive_byRef a, uint b) {
			return a.eeByRef ==b;
		}
		static public bool operator ==(Positive_byRef a, int b) {
			return a.eeByRef ==b;
		}

		static public bool operator !=(Positive_byRef a, int b)
		{
			return !(a == b);
		}

		static public bool operator !=(Positive_byRef a, uint b)
		{
			return !(a == b);
		}

		static public bool operator !=(uint b, Positive_byRef a)
		{
			return !(a == b);
		}
		static public bool operator ==(uint b, Positive_byRef a)
		{
			return a.eeByRef == b;
		}

		static public bool operator !=(Positive_byRef a, Positive_byRef b)
		{
			return !(a == b);
		}
		static public bool operator >=(Positive_byRef a, Positive_byRef b) {
			return a.eeByRef >=b.eeByRef;
		}
		static public bool operator >=(Positive_byRef a, uint b) {
			return a.eeByRef>=b;
		}
		static public bool operator <=(Positive_byRef a, Positive_byRef b) {
			return a.eeByRef<=b.eeByRef;
		}
		static public bool operator <=(Positive_byRef a, NumI1 b) {
			return a.eeByRef<=b.toBigint();
		}
		static public bool operator >=(Positive_byRef a, NumI1 b) {
			return a.eeByRef>=b.toBigint();
		}

		static public bool operator <=(Positive_byRef a, uint b) {
			return a.eeByRef<=b;
		}

		static public bool operator >(Positive_byRef a, Positive_byRef b) {
			return a.eeByRef>b.eeByRef;
		}
		static public bool operator >(Positive_byRef a, NumI1 b) {
			return a.eeByRef>b.toBigint();
		}
		static public bool operator <(Positive_byRef a, NumI1 b) {
			return a.eeByRef<b.toBigint();
		}


		static public bool operator >(Positive_byRef a, uint b) {
			return a.eeByRef>b;
		}
		static public bool operator <(Positive_byRef a, Positive_byRef b) {
			return a.eeByRef<b.eeByRef;
		}
		static public bool operator <(Positive_byRef a, uint b) {
			return a.eeByRef<b;
		}
		#endregion


		#region op

		#region unary

		static public Positive_byRef operator ++(  Positive_byRef a) {
			
			return new Positive_byRef( a.eeByRef+1 ); /*Because BigInteger objects are immutable, the Increment operator creates a new BigInteger object whose value is one more than the BigInteger object represented by value. Therefore, repeated calls to Increment may be expensive.*/
		}

		static public Positive_byRef operator --(  Positive_byRef a) {
			return new Positive_byRef(a.eeByRef-1);
		}
		#endregion

		static public Positive_byRef operator -(Positive_byRef a, int b) {
			return new Positive_byRef(a.eeByRef-b);
		}


		static public Positive_byRef operator +(Positive_byRef a, int b) {
			return new Positive_byRef(a.eeByRef+b);
		}

		static public Positive_byRef operator +(Positive_byRef a, Positive_byRef b) {
			return new Positive_byRef(a.eeByRef+b.eeByRef);
		}
		static public Positive_byRef operator *(Positive_byRef a, Positive_byRef b) {
			return new Positive_byRef(a.eeByRef*b.eeByRef);
		}
		static public Positive_byRef operator %(Positive_byRef a, uint b) {
			return new Positive_byRef( a.eeByRef%b );
		}

		static public BigInteger operator /(Positive_byRef a, int b) {
			return ( a.eeByRef/b );
		}
		static public Positive_byRef operator /(Positive_byRef a, uint b) {
			return  new Positive_byRef ( a.eeByRef/b );
		}




		#endregion



		static public readonly Positive_byRef One = new Positive_byRef(1);

		static public Positive_byRef CreateOne() {
			return new Positive_byRef(1);
		}

		public En toBigint()
		{
			return new En(eeByRef);
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as Positive_byRef);
		}

		public bool Equals(Positive_byRef other)
		{
			return other != null &&
				   eeByRef.Equals(other.eeByRef);
		}

		public override int GetHashCode()
		{
			return  eeByRef.GetHashCode();
		}
	}
}
