using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be_.natural.vow;

namespace nilnul.num_.ref_.vowless_
{
	public class Polyad
		:
		 IEquatable<Polyad>
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
		private Polyad(ref BigInteger integer)
		{
			_bigint =  integer;

		}

		private Polyad(BigInteger integer):this(ref integer) {

		}


		static public Polyad Of(
			ref BigInteger bigInteger
		)
		{
			nilnul._num.bigint.be_.polyad.Vow.Singleton.vow(ref bigInteger);

			return new Polyad(ref bigInteger);
		}
		static public Polyad Of(
			 BigInteger bigInteger
		)
		{
			return Of(ref bigInteger);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="i">expect a literal value, not a var, cuz we copy the value into our field, making the var's space wasted</param>
		static public Polyad Of(int i=3)
		{
			return Of((BigInteger)i);
		}



		static public readonly Polyad Three =  new Polyad(3);

		static public readonly Polyad Four =  new Polyad(4);
		static public readonly Polyad Five =  new Polyad(5);
		static public readonly Polyad Six =  new Polyad(6);
		static public readonly Polyad Seven =  new Polyad(7);

		static public readonly Polyad Eight =  new Polyad(8);
		static public readonly Polyad Nine =  new Polyad(9);
		static public readonly Polyad Ten =  new Polyad(10);
		static public readonly Polyad Eleven =  new Polyad(11);

		static public readonly Polyad Twelve =  new Polyad(12);
		static public readonly Polyad Thirteen =  new Polyad(13);
		static public readonly Polyad Fouteen =  new Polyad(14);
		static public readonly Polyad Fifteen =  new Polyad(15);

		static public readonly Polyad Sixteen =  new Polyad(16);
		static public readonly Polyad Seventeen =  new Polyad(17);
		static public readonly Polyad Eighteen =  new Polyad(18);
		static public readonly Polyad Nineteen =  new Polyad(19);

		static public readonly Polyad Twenty =  new Polyad(20);



		static public implicit operator BigInteger(Polyad num) {
			return num.eeByRef;
		}

		static public explicit operator Polyad(byte num) {
			return  Of(num);
		}

		static public explicit operator Polyad(ushort num) {
			return  Of(num);
		}
		static public explicit operator Polyad(uint num) {
			return Of(num);
		}

		static public explicit operator Polyad(ulong num) {
			return Of(num);
		}

		static public explicit operator Polyad(BigInteger bigint) {
			return  Of(ref bigint);
		}

		static public explicit operator Polyad(int bigint) {
			return Of(bigint);
		}
		static public explicit operator Polyad(long bigint) {
			return Of(bigint);
		}




		static public Polyad OvInteface( nilnul._num_.EeByRefI num)
		{
			switch (num)
			{
				case Polyad n:
					return n;
				default:

					return  Of(num.eeByRef);  
					break;
			}
		}

		#region re

		static public bool operator ==(Polyad a, Polyad b) {
			return a.eeByRef ==b.eeByRef;
		}
		static public bool operator !=(Polyad a, Polyad b)
		{
			return !(a == b);
		}

		static public bool operator ==(Polyad a, uint b) {
			return a.eeByRef ==b;
		}
		static public bool operator !=(Polyad a, uint b)
		{
			return !(a == b);
		}
		static public bool operator ==(Polyad a, int b) {
			return a.eeByRef ==b;
		}

		static public bool operator !=(Polyad a, int b)
		{
			return !(a == b);
		}


		static public bool operator ==(uint b, Polyad a)
		{
			return a.eeByRef == b;
		}
		static public bool operator !=(uint b, Polyad a)
		{
			return !(a == b);
		}

		static public bool operator >=(Polyad a, Polyad b) {
			return a.eeByRef >=b.eeByRef;
		}
		static public bool operator <=(Polyad a, Polyad b) {
			return a.eeByRef<=b.eeByRef;
		}

		static public bool operator >=(Polyad a, uint b) {
			return a.eeByRef>=b;
		}
		static public bool operator <=(Polyad a, uint b) {
			return a.eeByRef<=b;
		}
		static public bool operator >=(Polyad a, long b) {
			return a.eeByRef>=b;
		}
		static public bool operator <=(Polyad a, long b) {
			return a.eeByRef<=b;
		}

		static public bool operator >=(Polyad a, ulong b) {
			return a.eeByRef>=b;
		}
		static public bool operator <=(Polyad a, ulong b) {
			return a.eeByRef<=b;
		}

		static public bool operator >=(  Polyad a, _num_.EeByRefI b) {
			return a.eeByRef >=b.eeByRef;
		}
		static public bool operator <=(Polyad a, _num_.EeByRefI b) {
			return a.eeByRef <=b.eeByRef;
		}
		static public bool operator >=( _num_.EeByRefI b, Polyad a) {
			return b.eeByRef>=a.eeByRef;
		}

		static public bool operator <=( _num_.EeByRefI b, Polyad a) {
			return b.eeByRef <=a.eeByRef;
		}


		static public bool operator >(Polyad a, Polyad b) {
			return a.eeByRef>b.eeByRef;
		}
		static public bool operator <(Polyad a, Polyad b) {
			return a.eeByRef<b.eeByRef;
		}

		static public bool operator >(Polyad a, _num_.EeByRefI b) {
			return a.eeByRef>b.eeByRef;
		}
		static public bool operator <(Polyad a, _num_.EeByRefI b) {
			return a.eeByRef<b.eeByRef;
		}


		static public bool operator >(Polyad a, uint b) {
			return a.eeByRef>b;
		}
		static public bool operator <(Polyad a, uint b) {
			return a.eeByRef<b;
		}
		#endregion


		#region op

		#region unary

		static public Polyad operator ++(  Polyad a) {
			
			return new Polyad( a.eeByRef+1 ); /*Because BigInteger objects are immutable, the Increment operator creates a new BigInteger object whose value is one more than the BigInteger object represented by value. Therefore, repeated calls to Increment may be expensive.*/
		}

		static public Polyad operator --(  Polyad a) {
			return Of(a.eeByRef-1);
		}
		#endregion

		static public Polyad operator -(Polyad a, int b) {
			return Of(a.eeByRef-b);
		}



		static public Polyad operator +(Polyad a, Polyad b) {
			return new Polyad(a.eeByRef+b.eeByRef);
		}
		static public Polyad operator +(Polyad a, int b) {
			return Of(a.eeByRef+b);
		}

		static public Polyad operator *(Polyad a, Polyad b) {
			return new Polyad(a.eeByRef*b.eeByRef);
		}
		static public Polyad operator %(Polyad a, uint b) {
			return Of( a.eeByRef%b );
		}

		static public Polyad operator /(Polyad a, uint b) {
			return  Of( a.eeByRef/b );
		}
		static public BigInteger operator /(Polyad a, int b) {
			return Of( a.eeByRef / b );
		}




		#endregion


		public bool Equals(Polyad other)
		{
			return other != null &&
				   eeByRef.Equals(other.eeByRef);
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as Polyad);
		}


		public override int GetHashCode()
		{
			return  eeByRef.GetHashCode();
		}
	}
}
