using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be_.natural.vow;

namespace nilnul.num_.ref_.vowless_
{
	public class Plural
		:
		 IEquatable<Plural>
		,
		IByRef
		,
		nilnul.obj.vow._ee_.RetRefI<BigInteger>
		
	{
		private  BigInteger _bigint;

		/// <summary>
		/// follows the convention of <see cref="obj.vow.Ee_byRef{T}"/>, but keep the val here inside in order to circumvent some Vow
		/// </summary>
		public ref BigInteger eeByRef
		{
			get { return ref _bigint; }
			
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="integer"></param>
		private Plural(ref BigInteger integer)
		{
			_bigint =  integer;

		}

		

		private Plural(BigInteger integer):this(ref integer) {

		}


		static public Plural Of(
			ref BigInteger bigInteger
		)
		{
			//nilnul._num.bigint.be_.plural.Vow1.Unison.vow(ref bigInteger);
			nilnul._num.bigint.be_.plural.Vow1.Singleton.vow(ref bigInteger);

			return new Plural(ref bigInteger);
		}
		static public Plural Of(
			 BigInteger bigInteger
		)
		{
			return Of(ref bigInteger);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="i">expect a literal value, not a var, cuz we copy the value into our field, making the var's space wasted</param>
		static public Plural Of(int i=2)
		{
			return Of((BigInteger)i);
		}
		public override string ToString()
		{
			return this._bigint.ToString();
		}


		static public readonly Plural Two =  new Plural(2);
		static public readonly Plural Three =  new Plural(3);

		static public readonly Plural Four =  new Plural(4);
		static public readonly Plural Five =  new Plural(5);
		static public readonly Plural Six =  new Plural(6);
		static public readonly Plural Seven =  new Plural(7);

		static public readonly Plural Eight =  new Plural(8);
		static public readonly Plural Nine =  new Plural(9);
		static public readonly Plural Ten =  new Plural(10);
		static public readonly Plural Eleven =  new Plural(11);

		static public readonly Plural Twelve =  new Plural(12);
		static public readonly Plural Thirteen =  new Plural(13);
		static public readonly Plural Fouteen =  new Plural(14);
		static public readonly Plural Fifteen =  new Plural(15);

		static public readonly Plural Sixteen =  new Plural(16);
		static public readonly Plural Seventeen =  new Plural(17);
		static public readonly Plural Eighteen =  new Plural(18);
		static public readonly Plural Nineteen =  new Plural(19);

		static public readonly Plural Twenty =  new Plural(20);



		static public implicit operator BigInteger(Plural num) {
			return num.eeByRef;
		}

		static public explicit operator Plural(byte num) {
			return  Of(num);
		}

		static public explicit operator Plural(ushort num) {
			return  Of(num);
		}
		static public explicit operator Plural(uint num) {
			return Of(num);
		}

		static public explicit operator Plural(ulong num) {
			return Of(num);
		}

		static public explicit operator Plural(BigInteger bigint) {
			return  Of(ref bigint);
		}

		static public explicit operator Plural(int bigint) {
			return Of(bigint);
		}
		static public explicit operator Plural(long bigint) {
			return Of(bigint);
		}




		static public Plural OvInteface( nilnul._num_.EeByRefI num)
		{
			switch (num)
			{
				case Plural n:
					return n;
				default:

					return  Of(num.eeByRef);  
					break;
			}
		}

		#region re

		static public bool operator ==(Plural a, Plural b) {
			return a.eeByRef ==b.eeByRef;
		}
		static public bool operator !=(Plural a, Plural b)
		{
			return !(a == b);
		}

		static public bool operator ==(Plural a, uint b) {
			return a.eeByRef ==b;
		}
		static public bool operator !=(Plural a, uint b)
		{
			return !(a == b);
		}
		static public bool operator ==(Plural a, int b) {
			return a.eeByRef ==b;
		}

		static public bool operator !=(Plural a, int b)
		{
			return !(a == b);
		}


		static public bool operator ==(uint b, Plural a)
		{
			return a.eeByRef == b;
		}
		static public bool operator !=(uint b, Plural a)
		{
			return !(a == b);
		}

		static public bool operator >=(Plural a, Plural b) {
			return a.eeByRef >=b.eeByRef;
		}
		static public bool operator <=(Plural a, Plural b) {
			return a.eeByRef<=b.eeByRef;
		}

		static public bool operator >=(Plural a, uint b) {
			return a.eeByRef>=b;
		}
		static public bool operator <=(Plural a, uint b) {
			return a.eeByRef<=b;
		}
		static public bool operator >=(Plural a, long b) {
			return a.eeByRef>=b;
		}
		static public bool operator <=(Plural a, long b) {
			return a.eeByRef<=b;
		}

		static public bool operator >=(Plural a, ulong b) {
			return a.eeByRef>=b;
		}
		static public bool operator <=(Plural a, ulong b) {
			return a.eeByRef<=b;
		}

		static public bool operator >=(  Plural a, _num_.EeByRefI b) {
			return a.eeByRef >=b.eeByRef;
		}
		static public bool operator <=(Plural a, _num_.EeByRefI b) {
			return a.eeByRef <=b.eeByRef;
		}
		static public bool operator >=( _num_.EeByRefI b, Plural a) {
			return b.eeByRef>=a.eeByRef;
		}

		static public bool operator <=( _num_.EeByRefI b, Plural a) {
			return b.eeByRef <=a.eeByRef;
		}


		static public bool operator >(Plural a, Plural b) {
			return a.eeByRef>b.eeByRef;
		}
		static public bool operator <(Plural a, Plural b) {
			return a.eeByRef<b.eeByRef;
		}

		static public bool operator >(Plural a, _num_.EeByRefI b) {
			return a.eeByRef>b.eeByRef;
		}
		static public bool operator <(Plural a, _num_.EeByRefI b) {
			return a.eeByRef<b.eeByRef;
		}


		static public bool operator >(Plural a, uint b) {
			return a.eeByRef>b;
		}
		static public bool operator <(Plural a, uint b) {
			return a.eeByRef<b;
		}
		#endregion


		#region op

		#region unary

		static public Plural operator ++(  Plural a) {
			
			return new Plural( a.eeByRef+1 ); /*Because BigInteger objects are immutable, the Increment operator creates a new BigInteger object whose value is one more than the BigInteger object represented by value. Therefore, repeated calls to Increment may be expensive.*/
		}

		static public Plural operator --(  Plural a) {
			return Of(a.eeByRef-1);
		}
		#endregion

		static public Plural operator -(Plural a, int b) {
			return Of(a.eeByRef-b);
		}



		static public Plural operator +(Plural a, Plural b) {
			return new Plural(a.eeByRef+b.eeByRef);
		}
		static public Plural operator +(Plural a, int b) {
			return Of(a.eeByRef+b);
		}

		static public Plural operator *(Plural a, Plural b) {
			return new Plural(a.eeByRef*b.eeByRef);
		}
		static public Plural operator %(Plural a, uint b) {
			return Of( a.eeByRef%b );
		}

		static public Plural operator /(Plural a, uint b) {
			return  Of( a.eeByRef/b );
		}
		static public BigInteger operator /(Plural a, int b) {
			return Of( a.eeByRef / b );
		}




		#endregion


		public bool Equals(Plural other)
		{
			return other != null &&
				   eeByRef.Equals(other.eeByRef);
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as Plural);
		}


		public override int GetHashCode()
		{
			return  eeByRef.GetHashCode();
		}
	}
}
