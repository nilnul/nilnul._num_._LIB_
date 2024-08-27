using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be_.natural.vow;

namespace nilnul.num_.ref_.vowless_
{
	/// due to the immutability of BigInteger, boxing an outside reference is safe. But we cannot have a field that is a ref as the referenced might be garbage collected and break our reference.
	/// <summary>
	/// box a bigint directly rather than thru a vowee like <see cref="nilnul._num.bigint.be_.natural.vow.Ee_byRef"/> in order to internally bypass some check. the bigint is immutable, so this class just assures the caller that value is natural, whileas this class cannot alter the boxed.
	/// </summary>
	/// <remarks>
	/// due to the vowing process, for performance reasons, use the BigInteger for computation. This class is mainly used to transfer an assurance when communicating a parameter.
	/// </remarks>
	public struct Struc
		:
		 IEquatable<Struc>
		,
		IByRef
		,
		nilnul.obj.vow._ee_.RetRefI<BigInteger>
		
	{
		private  BigInteger _bigint;

		/// <summary>
		/// follows the convention of <see cref="obj.vow.Ee_byRef{T}"/>, but keep the val here inside in order to circumvent some Vow
		/// </summary>
		public  BigInteger eeByRef
		{
			get { return  _bigint; } //we can ref this whole struct. but it seems here a copy is transferred out.
			
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="integer"></param>
		/// <param name="o">useless, just differentiate this from other ctor</param>
		private Struc(ref BigInteger integer)
		{
			_bigint =  integer;

		}

		private Struc(BigInteger integer):this(ref integer) {

		}

		/*
		/// <summary>
		/// a copy of the val will be passed. then we get the reference, then the field compy the referenced value. So at least two copies are needed.
		/// </summary>
		/// <param name="bigint"></param>
		///
		public BypassVow( BigInteger bigint)
			:this(ref bigint)
		{
			nilnul._num.bigint.be_.natural.Vow1.Singleton.vow(ref bigint);
		}
		*/


		static public Struc Of(
			ref BigInteger bigInteger
		)
		{
			nilnul._num.bigint.be_.natural.Vow1.Singleton.vow(ref bigInteger);

			return new Struc(ref bigInteger);
		}
		/// <summary>
		/// used only when no refVar is available, for example, if an expr is transferred in.
		/// </summary>
		/// <param name="bigInteger"></param>
		/// <returns></returns>
		static public Struc Of(
			 BigInteger bigInteger
		)
		{
			return Of(ref bigInteger);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="i">expect a literal value, not a var, cuz we copy the value into our field, making the var's space wasted</param>
		static public Struc Of(int i=0)
		{
			return Of((BigInteger)i);
			BigInteger x = i;
			return Of(ref x);
		}



		static public readonly Struc Nil =  new Struc(0);
		static public readonly Struc One =  new Struc(1);
		static public readonly Struc Two =  new Struc(2);
		static public readonly Struc Three =  new Struc(3);

		static public readonly Struc Four =  new Struc(4);
		static public readonly Struc Five =  new Struc(5);
		static public readonly Struc Six =  new Struc(6);
		static public readonly Struc Seven =  new Struc(7);

		static public readonly Struc Eight =  new Struc(8);
		static public readonly Struc Nine =  new Struc(9);
		static public readonly Struc Ten =  new Struc(10);
		static public readonly Struc Eleven =  new Struc(11);

		static public readonly Struc Twelve =  new Struc(12);
		static public readonly Struc Thirteen =  new Struc(13);
		static public readonly Struc Fouteen =  new Struc(14);
		static public readonly Struc Fifteen =  new Struc(15);

		static public readonly Struc Sixteen =  new Struc(16);
		static public readonly Struc Seventeen =  new Struc(17);
		static public readonly Struc Eighteen =  new Struc(18);
		static public readonly Struc Nineteen =  new Struc(19);

		static public readonly Struc Twenty =  new Struc(20);



		static public implicit operator BigInteger(Struc num) {
			return num.eeByRef;
		}

		static public implicit operator Struc(byte num) {
			return new Struc(num);
		}

		static public implicit operator Struc(ushort num) {
			return new Struc(num);
		}
		static public implicit operator Struc(uint num) {
			return new Struc(num);
		}

		static public implicit operator Struc(ulong num) {
			return new Struc(num);
		}

		static public explicit operator Struc(BigInteger bigint) {
			return  Of(ref bigint);
		}

		static public explicit operator Struc(int bigint) {
			return Of(bigint);
		}
		static public explicit operator Struc(long bigint) {
			return Of(bigint);
		}



		//from base is not allowed

		static public Struc OvInteface( nilnul._num_.EeByRefI num)
		{
			switch (num)
			{
				case Struc n:
					return n;
				default:

					return new Struc(num.eeByRef);  //no need to check
					break;
			}
		}

		#region re

		static public bool operator ==(Struc a, Struc b) {
			return a.eeByRef ==b.eeByRef;
		}
		static public bool operator !=(Struc a, Struc b)
		{
			return !(a == b);
		}

		static public bool operator ==(Struc a, uint b) {
			return a.eeByRef ==b;
		}
		static public bool operator !=(Struc a, uint b)
		{
			return !(a == b);
		}
		static public bool operator ==(Struc a, int b) {
			return a.eeByRef ==b;
		}

		static public bool operator !=(Struc a, int b)
		{
			return !(a == b);
		}


		static public bool operator ==(uint b, Struc a)
		{
			return a.eeByRef == b;
		}
		static public bool operator !=(uint b, Struc a)
		{
			return !(a == b);
		}

		static public bool operator >=(Struc a, Struc b) {
			return a.eeByRef >=b.eeByRef;
		}
		static public bool operator <=(Struc a, Struc b) {
			return a.eeByRef<=b.eeByRef;
		}

		static public bool operator >=(Struc a, uint b) {
			return a.eeByRef>=b;
		}
		static public bool operator <=(Struc a, uint b) {
			return a.eeByRef<=b;
		}
		static public bool operator >=(Struc a, long b) {
			return a.eeByRef>=b;
		}
		static public bool operator <=(Struc a, long b) {
			return a.eeByRef<=b;
		}

		static public bool operator >=(Struc a, ulong b) {
			return a.eeByRef>=b;
		}
		static public bool operator <=(Struc a, ulong b) {
			return a.eeByRef<=b;
		}

		static public bool operator >=(  Struc a, _num_.EeByRefI b) {
			return a.eeByRef >=b.eeByRef;
		}
		static public bool operator <=(Struc a, _num_.EeByRefI b) {
			return a.eeByRef<=b.eeByRef;
		}
		static public bool operator >=( _num_.EeByRefI b, Struc a) {
			return b.eeByRef>=a.eeByRef;
		}

		static public bool operator <=( _num_.EeByRefI b, Struc a) {
			return b.eeByRef <=a.eeByRef;
		}


		static public bool operator >(Struc a, Struc b) {
			return a.eeByRef>b.eeByRef;
		}
		static public bool operator >(Struc a, _num_.EeByRefI b) {
			return a.eeByRef>b.eeByRef;
		}
		static public bool operator <(Struc a, _num_.EeByRefI b) {
			return a.eeByRef<b.eeByRef;
		}


		static public bool operator >(Struc a, uint b) {
			return a.eeByRef>b;
		}
		static public bool operator <(Struc a, Struc b) {
			return a.eeByRef<b.eeByRef;
		}
		static public bool operator <(Struc a, uint b) {
			return a.eeByRef<b;
		}
		#endregion


		#region op

		#region unary

		static public Struc operator ++(  Struc a) {
			
			return new Struc( a.eeByRef+1 ); /*Because BigInteger objects are immutable, the Increment operator creates a new BigInteger object whose value is one more than the BigInteger object represented by value. Therefore, repeated calls to Increment may be expensive.*/
		}

		static public Struc operator --(  Struc a) {
			return Of(a.eeByRef-1);
		}
		#endregion

		static public Struc operator -(Struc a, int b) {
			return Of(a.eeByRef-b);
		}


		static public Struc operator +(Struc a, int b) {
			return Of(a.eeByRef+b);
		}

		static public Struc operator +(Struc a, Struc b) {
			return new Struc(a.eeByRef+b.eeByRef);
		}
		static public Struc operator *(Struc a, Struc b) {
			return new Struc(a.eeByRef*b.eeByRef);
		}
		static public Struc operator %(Struc a, uint b) {
			return new Struc( a.eeByRef%b );
		}

		static public BigInteger operator /(Struc a, int b) {
			return Of( a.eeByRef / b );
		}
		static public Struc operator /(Struc a, uint b) {
			return  new Struc ( a.eeByRef/b );
		}




		#endregion


		public bool Equals(Struc other)
		{
			return other != null &&
				   eeByRef.Equals(other.eeByRef);
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as Struc);
		}


		public override int GetHashCode()
		{
			return  eeByRef.GetHashCode();
		}
	}
}
