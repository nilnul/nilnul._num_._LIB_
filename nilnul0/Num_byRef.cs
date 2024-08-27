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
	/// </summary>

	[Obsolete(nameof(nilnul.Num_ofIn))]
	public class Num_byRef: nilnul._num.bigint.be_.natural.vow.Ee_byRef, NumI1, IEquatable<Num_byRef>
		,
		INum
		,
		num_.IByRef
	{

		public ref BigInteger bigint
		{
			get { return ref this.eeByRef; }
			
		}
	

	



		public Num_byRef(ref BigInteger bigint):base(ref bigint)
		{

		}

		public Num_byRef( BigInteger bigint):this(ref bigint)
		{

		}

		public Num_byRef(uint uintVal)
			:this((BigInteger)uintVal)
		{
		}
		public Num_byRef():this(0)
		{

		}


	

		public Num_byRef(nilnul._num.bigint.be_.natural.vow.En x):this(x.en)
		{
		}

		

		public Num_byRef(NumI x):this(x.toBigint())
		{
		}
		public Num_byRef(Num x):this(x.toBigint())
		{
		}

		static public implicit operator BigInteger(Num_byRef num) {
			return num.eeByRef;
		}

		static public implicit operator Num_byRef(uint num) {
			return new Num_byRef(num);
		}

		static public implicit operator Num(Num_byRef num) {
			return new Num( num.eeByRef);
		}
		//static public explicit operator Num(Num1 num) {
		//	return new Num( num.en);
		//}


		static public implicit operator Num_byRef(Num num) {
			return new Num_byRef(num);
		}

		static public explicit operator Num_byRef(BigInteger bigint) {
			return new Num_byRef(bigint);
		}

		static public explicit operator Num_byRef(int bigint) {
			return new Num_byRef(bigint);
		}


		//from base is not allowed
		static public implicit operator Num_byRef(_num.bigint.be.Natural.Asserted num)
		{
			return num;
		}

		static public nilnul.Num_byRef OvInteface( nilnul.NumI1 num)
		{
			switch (num)
			{
				case Num_byRef n:
					return n;
				default:
					return new Num_byRef(num.toBigint());
					break;
			}
		}


		#region re

		static public bool operator ==(Num_byRef a, Num_byRef b) {
			return a.eeByRef ==b.eeByRef;
		}
		static public bool operator ==(Num_byRef a, uint b) {
			return a.eeByRef ==b;
		}
		static public bool operator ==(Num_byRef a, int b) {
			return a.eeByRef ==b;
		}

		static public bool operator !=(Num_byRef a, int b)
		{
			return !(a == b);
		}

		static public bool operator !=(Num_byRef a, uint b)
		{
			return !(a == b);
		}

		static public bool operator !=(uint b, Num_byRef a)
		{
			return !(a == b);
		}
		static public bool operator ==(uint b, Num_byRef a)
		{
			return a.eeByRef == b;
		}

		static public bool operator !=(Num_byRef a, Num_byRef b)
		{
			return !(a == b);
		}
		static public bool operator >=(Num_byRef a, Num_byRef b) {
			return a.eeByRef >=b.eeByRef;
		}
		static public bool operator >=(Num_byRef a, uint b) {
			return a.eeByRef>=b;
		}
		static public bool operator <=(Num_byRef a, Num_byRef b) {
			return a.eeByRef<=b.eeByRef;
		}
		static public bool operator <=(Num_byRef a, NumI1 b) {
			return a.eeByRef<=b.toBigint();
		}
		static public bool operator >=(Num_byRef a, NumI1 b) {
			return a.eeByRef>=b.toBigint();
		}

		static public bool operator <=(Num_byRef a, uint b) {
			return a.eeByRef<=b;
		}

		static public bool operator >(Num_byRef a, Num_byRef b) {
			return a.eeByRef>b.eeByRef;
		}
		static public bool operator >(Num_byRef a, NumI1 b) {
			return a.eeByRef>b.toBigint();
		}
		static public bool operator <(Num_byRef a, NumI1 b) {
			return a.eeByRef<b.toBigint();
		}


		static public bool operator >(Num_byRef a, uint b) {
			return a.eeByRef>b;
		}
		static public bool operator <(Num_byRef a, Num_byRef b) {
			return a.eeByRef<b.eeByRef;
		}
		static public bool operator <(Num_byRef a, uint b) {
			return a.eeByRef<b;
		}
		#endregion


		#region op

		#region unary

		static public Num_byRef operator ++(  Num_byRef a) {
			
			return new Num_byRef( a.eeByRef+1 ); /*Because BigInteger objects are immutable, the Increment operator creates a new BigInteger object whose value is one more than the BigInteger object represented by value. Therefore, repeated calls to Increment may be expensive.*/
		}

		static public Num_byRef operator --(  Num_byRef a) {
			return new Num_byRef(a.eeByRef-1);
		}
		#endregion

		static public Num_byRef operator -(Num_byRef a, int b) {
			return new Num_byRef(a.eeByRef-b);
		}


		static public Num_byRef operator +(Num_byRef a, int b) {
			return new Num_byRef(a.eeByRef+b);
		}

		static public Num_byRef operator +(Num_byRef a, Num_byRef b) {
			return new Num_byRef(a.eeByRef+b.eeByRef);
		}
		static public Num_byRef operator *(Num_byRef a, Num_byRef b) {
			return new Num_byRef(a.eeByRef*b.eeByRef);
		}
		static public Num_byRef operator %(Num_byRef a, uint b) {
			return new Num_byRef( a.eeByRef%b );
		}

		static public BigInteger operator /(Num_byRef a, int b) {
			return ( a.eeByRef/b );
		}
		static public Num_byRef operator /(Num_byRef a, uint b) {
			return  new Num_byRef ( a.eeByRef/b );
		}




		#endregion


		static public readonly Num_byRef Nil = new Num_byRef();
		static public readonly Num_byRef One = new Num_byRef(1);

		static public Num_byRef CreateZero() {
			return new Num_byRef();
		}

		static public Num_byRef CreateOne() {
			return new Num_byRef(1);
		}

		public En toBigint()
		{
			return new En(eeByRef);
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as Num_byRef);
		}

		public bool Equals(Num_byRef other)
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
