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
	///
	[Obsolete(nameof(num_.ref_.vowless_.Polyad) + " is more performant")]

	public class Polyad8ref: nilnul._num.bigint.be_.plural.vow.Ee_byRef, NumI1, IEquatable<Polyad8ref>
	{


		public ref BigInteger bigint
		{
			get { return ref this.eeByRef; }
			
		}


		public Polyad8ref(ref BigInteger bigint):base(ref bigint)
		{

		}

		public Polyad8ref( BigInteger bigint):this(ref bigint)
		{

		}

		public Polyad8ref(uint uintVal)
			:this((BigInteger)uintVal)
		{
		}
		public Polyad8ref():this(3)
		{

		}


	

		public Polyad8ref(nilnul._num.bigint.be_.natural.vow.En x):this(x.en)
		{
		}

		

		public Polyad8ref(NumI x):this(x.toBigint())
		{
		}
		public Polyad8ref(Num x):this(x.toBigint())
		{
		}

		static public implicit operator BigInteger(Polyad8ref num) {
			return num.eeByRef;
		}

		static public explicit operator Polyad8ref(uint num) {
			return new Polyad8ref(num);
		}

		static public implicit operator Num(Polyad8ref num) {
			return new Num( num.eeByRef);
		}
		//static public explicit operator Num(Num1 num) {
		//	return new Num( num.en);
		//}


		static public explicit operator Polyad8ref(Num num) {
			return new Polyad8ref(num);
		}

		static public explicit operator Polyad8ref(BigInteger bigint) {
			return new Polyad8ref(bigint);
		}

		static public explicit operator Polyad8ref(int bigint) {
			return new Polyad8ref(bigint);
		}


		//from base is not allowed
		static public explicit operator Polyad8ref(_num.bigint.be.Natural.Asserted num)
		{
			return new Polyad8ref(num);
		}

		static public nilnul.num_.Polyad8ref OvInteface( nilnul.NumI1 num)
		{
			switch (num)
			{
				case Polyad8ref n:
					return n;
				default:
					return new Polyad8ref(num.toBigint());
					break;
			}
		}


		#region re

		static public bool operator ==(Polyad8ref a, Polyad8ref b) {
			return a.eeByRef ==b.eeByRef;
		}
		static public bool operator ==(Polyad8ref a, uint b) {
			return a.eeByRef ==b;
		}
		static public bool operator ==(Polyad8ref a, int b) {
			return a.eeByRef ==b;
		}

		static public bool operator !=(Polyad8ref a, int b)
		{
			return !(a == b);
		}

		static public bool operator !=(Polyad8ref a, uint b)
		{
			return !(a == b);
		}

		static public bool operator !=(uint b, Polyad8ref a)
		{
			return !(a == b);
		}
		static public bool operator ==(uint b, Polyad8ref a)
		{
			return a.eeByRef == b;
		}

		static public bool operator !=(Polyad8ref a, Polyad8ref b)
		{
			return !(a == b);
		}
		static public bool operator >=(Polyad8ref a, Polyad8ref b) {
			return a.eeByRef >=b.eeByRef;
		}
		static public bool operator >=(Polyad8ref a, uint b) {
			return a.eeByRef>=b;
		}
		static public bool operator <=(Polyad8ref a, Polyad8ref b) {
			return a.eeByRef<=b.eeByRef;
		}
		static public bool operator <=(Polyad8ref a, NumI1 b) {
			return a.eeByRef<=b.toBigint();
		}
		static public bool operator >=(Polyad8ref a, NumI1 b) {
			return a.eeByRef>=b.toBigint();
		}

		static public bool operator <=(Polyad8ref a, uint b) {
			return a.eeByRef<=b;
		}

		static public bool operator >(Polyad8ref a, Polyad8ref b) {
			return a.eeByRef>b.eeByRef;
		}
		static public bool operator >(Polyad8ref a, NumI1 b) {
			return a.eeByRef>b.toBigint();
		}
		static public bool operator <(Polyad8ref a, NumI1 b) {
			return a.eeByRef<b.toBigint();
		}


		static public bool operator >(Polyad8ref a, uint b) {
			return a.eeByRef>b;
		}
		static public bool operator <(Polyad8ref a, Polyad8ref b) {
			return a.eeByRef<b.eeByRef;
		}
		static public bool operator <(Polyad8ref a, uint b) {
			return a.eeByRef<b;
		}
		#endregion


		#region op

		#region unary

		static public Polyad8ref operator ++(  Polyad8ref a) {
			
			return new Polyad8ref( a.eeByRef+1 ); /*Because BigInteger objects are immutable, the Increment operator creates a new BigInteger object whose value is one more than the BigInteger object represented by value. Therefore, repeated calls to Increment may be expensive.*/
		}

		static public Polyad8ref operator --(  Polyad8ref a) {
			return new Polyad8ref(a.eeByRef-1);
		}
		#endregion

		static public Polyad8ref operator -(Polyad8ref a, int b) {
			return new Polyad8ref(a.eeByRef-b);
		}


		static public Polyad8ref operator +(Polyad8ref a, int b) {
			return new Polyad8ref(a.eeByRef+b);
		}

		static public Polyad8ref operator +(Polyad8ref a, Polyad8ref b) {
			return new Polyad8ref(a.eeByRef+b.eeByRef);
		}
		static public Polyad8ref operator *(Polyad8ref a, Polyad8ref b) {
			return new Polyad8ref(a.eeByRef*b.eeByRef);
		}
		static public Polyad8ref operator %(Polyad8ref a, uint b) {
			return new Polyad8ref( a.eeByRef%b );
		}

		static public BigInteger operator /(Polyad8ref a, int b) {
			return ( a.eeByRef/b );
		}
		static public Polyad8ref operator /(Polyad8ref a, uint b) {
			return  new Polyad8ref ( a.eeByRef/b );
		}




		#endregion



		static public readonly Polyad8ref Three = new Polyad8ref(3);

		static public Polyad8ref CreateThree() {
			return new Polyad8ref(3);
		}

		public En toBigint()
		{
			return new En(eeByRef);
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as Polyad8ref);
		}

		public bool Equals(Polyad8ref other)
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
