using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be_.natural.vow;

namespace nilnul.num_.ref_.vowless_
{
	public class Positive
		:
		 IEquatable<Positive>
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
		private Positive(ref BigInteger integer)
		{
			_bigint =  integer;

		}

		private Positive(BigInteger integer):this(ref integer) {

		}


		static public Positive Of(
			ref BigInteger bigInteger
		)
		{
			nilnul._num.bigint.be_.positive.Vow.Singleton.vow(ref bigInteger);

			return new Positive(ref bigInteger);
		}
		static public Positive Of(
			 BigInteger bigInteger
		)
		{
			return Of(ref bigInteger);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="i">expect a literal value, not a var, cuz we copy the value into our field, making the var's space wasted</param>
		static public Positive Of(int i=1)
		{
			return Of((BigInteger)i);
		}



		static public readonly Positive One =  new Positive(1);
		static public readonly Positive Two =  new Positive(2);
		static public readonly Positive Three =  new Positive(3);

		static public readonly Positive Four =  new Positive(4);
		static public readonly Positive Five =  new Positive(5);
		static public readonly Positive Six =  new Positive(6);
		static public readonly Positive Seven =  new Positive(7);

		static public readonly Positive Eight =  new Positive(8);
		static public readonly Positive Nine =  new Positive(9);
		static public readonly Positive Ten =  new Positive(10);
		static public readonly Positive Eleven =  new Positive(11);

		static public readonly Positive Twelve =  new Positive(12);
		static public readonly Positive Thirteen =  new Positive(13);
		static public readonly Positive Fouteen =  new Positive(14);
		static public readonly Positive Fifteen =  new Positive(15);

		static public readonly Positive Sixteen =  new Positive(16);
		static public readonly Positive Seventeen =  new Positive(17);
		static public readonly Positive Eighteen =  new Positive(18);
		static public readonly Positive Nineteen =  new Positive(19);

		static public readonly Positive Twenty =  new Positive(20);



		static public implicit operator BigInteger(Positive num) {
			return num.eeByRef;
		}

		static public explicit operator Positive(byte num) {
			return  Positive.Of(num);
		}

		static public explicit operator Positive(ushort num) {
			return  Of(num);
		}
		static public explicit operator Positive(uint num) {
			return Of(num);
		}

		static public explicit operator Positive(ulong num) {
			return Of(num);
		}

		static public explicit operator Positive(BigInteger bigint) {
			return  Of(ref bigint);
		}

		static public explicit operator Positive(int bigint) {
			return Of(bigint);
		}
		static public explicit operator Positive(long bigint) {
			return Of(bigint);
		}




		static public Positive OvInteface( nilnul._num_.EeByRefI num)
		{
			switch (num)
			{
				case Positive n:
					return n;
				default:

					return  Of(num.eeByRef); 
					break;
			}
		}

		#region re

		static public bool operator ==(Positive a, Positive b) {
			return a.eeByRef ==b.eeByRef;
		}
		static public bool operator !=(Positive a, Positive b)
		{
			return !(a == b);
		}

		static public bool operator ==(Positive a, uint b) {
			return a.eeByRef ==b;
		}
		static public bool operator !=(Positive a, uint b)
		{
			return !(a == b);
		}
		static public bool operator ==(Positive a, int b) {
			return a.eeByRef ==b;
		}

		static public bool operator !=(Positive a, int b)
		{
			return !(a == b);
		}


		static public bool operator ==(uint b, Positive a)
		{
			return a.eeByRef == b;
		}
		static public bool operator !=(uint b, Positive a)
		{
			return !(a == b);
		}

		static public bool operator >=(Positive a, Positive b) {
			return a.eeByRef >=b.eeByRef;
		}
		static public bool operator <=(Positive a, Positive b) {
			return a.eeByRef<=b.eeByRef;
		}

		static public bool operator >=(Positive a, uint b) {
			return a.eeByRef>=b;
		}
		static public bool operator <=(Positive a, uint b) {
			return a.eeByRef<=b;
		}
		static public bool operator >=(Positive a, long b) {
			return a.eeByRef>=b;
		}
		static public bool operator <=(Positive a, long b) {
			return a.eeByRef<=b;
		}

		static public bool operator >=(Positive a, ulong b) {
			return a.eeByRef>=b;
		}
		static public bool operator <=(Positive a, ulong b) {
			return a.eeByRef<=b;
		}

		static public bool operator >=(  Positive a, _num_.EeByRefI b) {
			return a.eeByRef >=b.eeByRef;
		}
		static public bool operator <=(Positive a, _num_.EeByRefI b) {
			return a.eeByRef <=b.eeByRef;
		}
		static public bool operator >=( _num_.EeByRefI b, Positive a) {
			return b.eeByRef>=a.eeByRef;
		}

		static public bool operator <=( _num_.EeByRefI b, Positive a) {
			return b.eeByRef <=a.eeByRef;
		}


		static public bool operator >(Positive a, Positive b) {
			return a.eeByRef>b.eeByRef;
		}
		static public bool operator <(Positive a, Positive b) {
			return a.eeByRef<b.eeByRef;
		}

		static public bool operator >(Positive a, _num_.EeByRefI b) {
			return a.eeByRef>b.eeByRef;
		}
		static public bool operator <(Positive a, _num_.EeByRefI b) {
			return a.eeByRef<b.eeByRef;
		}


		static public bool operator >(Positive a, uint b) {
			return a.eeByRef>b;
		}
		static public bool operator <(Positive a, uint b) {
			return a.eeByRef<b;
		}
		#endregion


		#region op

		#region unary

		static public Positive operator ++(  Positive a) {
			
			return new Positive( a.eeByRef+1 ); /*Because BigInteger objects are immutable, the Increment operator creates a new BigInteger object whose value is one more than the BigInteger object represented by value. Therefore, repeated calls to Increment may be expensive.*/
		}

		static public Positive operator --(  Positive a) {
			return Of(a.eeByRef-1);
		}
		#endregion

		static public Positive operator -(Positive a, int b) {
			return Of(a.eeByRef-b);
		}



		static public Positive operator +(Positive a, Positive b) {
			return new Positive(a.eeByRef+b.eeByRef);
		}
		static public Positive operator +(Positive a, int b) {
			return Of(a.eeByRef+b);
		}

		static public Positive operator *(Positive a, Positive b) {
			return new Positive(a.eeByRef*b.eeByRef);
		}
		static public Positive operator %(Positive a, uint b) {
			return Of( a.eeByRef%b );
		}

		static public Positive operator /(Positive a, uint b) {
			return  Of( a.eeByRef/b );
		}
		static public BigInteger operator /(Positive a, int b) {
			return Of( a.eeByRef / b );
		}




		#endregion


		public bool Equals(Positive other)
		{
			return other != null &&
				   eeByRef.Equals(other.eeByRef);
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as Positive);
		}


		public override int GetHashCode()
		{
			return  eeByRef.GetHashCode();
		}
	}
}
