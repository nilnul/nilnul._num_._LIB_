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
 	[Obsolete(nameof(num_.ref_.vowless_.Plural) + " is more performant")]

	public class Plural8ref: nilnul._num.bigint.be_.plural.vow.Ee_byRef, NumI1, IEquatable<Plural8ref>
	{


		public ref BigInteger bigint
		{
			get { return ref this.eeByRef; }
			
		}


		public Plural8ref(ref BigInteger bigint):base(ref bigint)
		{

		}

		public Plural8ref( BigInteger bigint):this(ref bigint)
		{

		}

		public Plural8ref(uint uintVal)
			:this((BigInteger)uintVal)
		{
		}
		public Plural8ref():this(2)
		{

		}


	

		public Plural8ref(nilnul._num.bigint.be_.natural.vow.En x):this(x.en)
		{
		}

		

		public Plural8ref(NumI x):this(x.toBigint())
		{
		}
		public Plural8ref(Num x):this(x.toBigint())
		{
		}

		static public implicit operator BigInteger(Plural8ref num) {
			return num.eeByRef;
		}

		static public explicit operator Plural8ref(uint num) {
			return new Plural8ref(num);
		}

		static public implicit operator Num(Plural8ref num) {
			return new Num( num.eeByRef);
		}
		//static public explicit operator Num(Num1 num) {
		//	return new Num( num.en);
		//}


		static public explicit operator Plural8ref(Num num) {
			return new Plural8ref(num);
		}

		static public explicit operator Plural8ref(BigInteger bigint) {
			return new Plural8ref(bigint);
		}

		static public explicit operator Plural8ref(int bigint) {
			return new Plural8ref(bigint);
		}


		//from base is not allowed
		static public explicit operator Plural8ref(_num.bigint.be.Natural.Asserted num)
		{
			return new Plural8ref(num);
		}

		static public nilnul.num_.Plural8ref OvInteface( nilnul.NumI1 num)
		{
			switch (num)
			{
				case Plural8ref n:
					return n;
				default:
					return new Plural8ref(num.toBigint());
					break;
			}
		}


		#region re

		static public bool operator ==(Plural8ref a, Plural8ref b) {
			return a.eeByRef ==b.eeByRef;
		}
		static public bool operator ==(Plural8ref a, uint b) {
			return a.eeByRef ==b;
		}
		static public bool operator ==(Plural8ref a, int b) {
			return a.eeByRef ==b;
		}

		static public bool operator !=(Plural8ref a, int b)
		{
			return !(a == b);
		}

		static public bool operator !=(Plural8ref a, uint b)
		{
			return !(a == b);
		}

		static public bool operator !=(uint b, Plural8ref a)
		{
			return !(a == b);
		}
		static public bool operator ==(uint b, Plural8ref a)
		{
			return a.eeByRef == b;
		}

		static public bool operator !=(Plural8ref a, Plural8ref b)
		{
			return !(a == b);
		}
		static public bool operator >=(Plural8ref a, Plural8ref b) {
			return a.eeByRef >=b.eeByRef;
		}
		static public bool operator >=(Plural8ref a, uint b) {
			return a.eeByRef>=b;
		}
		static public bool operator <=(Plural8ref a, Plural8ref b) {
			return a.eeByRef<=b.eeByRef;
		}
		static public bool operator <=(Plural8ref a, NumI1 b) {
			return a.eeByRef<=b.toBigint();
		}
		static public bool operator >=(Plural8ref a, NumI1 b) {
			return a.eeByRef>=b.toBigint();
		}

		static public bool operator <=(Plural8ref a, uint b) {
			return a.eeByRef<=b;
		}

		static public bool operator >(Plural8ref a, Plural8ref b) {
			return a.eeByRef>b.eeByRef;
		}
		static public bool operator >(Plural8ref a, NumI1 b) {
			return a.eeByRef>b.toBigint();
		}
		static public bool operator <(Plural8ref a, NumI1 b) {
			return a.eeByRef<b.toBigint();
		}


		static public bool operator >(Plural8ref a, uint b) {
			return a.eeByRef>b;
		}
		static public bool operator <(Plural8ref a, Plural8ref b) {
			return a.eeByRef<b.eeByRef;
		}
		static public bool operator <(Plural8ref a, uint b) {
			return a.eeByRef<b;
		}
		#endregion


		#region op

		#region unary

		static public Plural8ref operator ++(  Plural8ref a) {
			
			return new Plural8ref( a.eeByRef+1 ); /*Because BigInteger objects are immutable, the Increment operator creates a new BigInteger object whose value is one more than the BigInteger object represented by value. Therefore, repeated calls to Increment may be expensive.*/
		}

		static public Plural8ref operator --(  Plural8ref a) {
			return new Plural8ref(a.eeByRef-1);
		}
		#endregion

		static public Plural8ref operator -(Plural8ref a, int b) {
			return new Plural8ref(a.eeByRef-b);
		}


		static public Plural8ref operator +(Plural8ref a, int b) {
			return new Plural8ref(a.eeByRef+b);
		}

		static public Plural8ref operator +(Plural8ref a, Plural8ref b) {
			return new Plural8ref(a.eeByRef+b.eeByRef);
		}
		static public Plural8ref operator *(Plural8ref a, Plural8ref b) {
			return new Plural8ref(a.eeByRef*b.eeByRef);
		}
		static public Plural8ref operator %(Plural8ref a, uint b) {
			return new Plural8ref( a.eeByRef%b );
		}

		static public BigInteger operator /(Plural8ref a, int b) {
			return ( a.eeByRef/b );
		}
		static public Plural8ref operator /(Plural8ref a, uint b) {
			return  new Plural8ref ( a.eeByRef/b );
		}




		#endregion



		static public readonly Plural8ref Two = new Plural8ref(2);

		static public Plural8ref CreateTwo() {
			return new Plural8ref(2);
		}

		public En toBigint()
		{
			return new En(eeByRef);
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as Plural8ref);
		}

		public bool Equals(Plural8ref other)
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
