using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be_.natural.vow;

namespace nilnul.num_.ref_
{
	/// due to the immutability of BigInteger, boxing an outside reference is safe. But we cannot have a field that is a ref as the referenced might be garbage collected and break our reference.
	/// <summary>
	/// box a bigint directly rather than thru a vowee like <see cref="nilnul._num.bigint.be_.natural.vow.Ee_byRef"/> in order to internally bypass some check. the bigint is immutable, so this class just assures the caller that value is natural, whileas this class cannot alter the boxed.
	/// </summary>
	/// <remarks>
	/// due to the vowing process, for performance reasons, use the BigInteger for computation. This class is mainly used to transfer an assurance when communicating a parameter.
	/// </remarks>
	///
	[Obsolete(nameof(nilnul.Num_ofIn))]
	public class BypassVow
		:
		 IEquatable<BypassVow>
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
		/// <param name="o">useless, just differentiate this from other ctor</param>
		private BypassVow(ref BigInteger integer)
		{
			_bigint =  integer;

		}

		private BypassVow(BigInteger integer):this(ref integer) {

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


		static public BypassVow Of(
			ref BigInteger bigInteger
		)
		{
			nilnul._num.bigint.be_.natural.Vow1.Singleton.vow(ref bigInteger);

			return new BypassVow(ref bigInteger);
		}
		/// <summary>
		/// used only when no refVar is available, for example, if an expr is transferred in.
		/// </summary>
		/// <param name="bigInteger"></param>
		/// <returns></returns>
		static public BypassVow Of(
			 BigInteger bigInteger
		)
		{
			return Of(ref bigInteger);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="i">expect a literal value, not a var, cuz we copy the value into our field, making the var's space wasted</param>
		static public BypassVow Of(int i=0)
		{
			return Of((BigInteger)i);
			BigInteger x = i;
			return Of(ref x);
		}



		static public readonly  BypassVow Nil =  new BypassVow(0);
		static public readonly BypassVow One =  new BypassVow(1);
		static public readonly BypassVow Two =  new BypassVow(2);
		static public readonly BypassVow Three =  new BypassVow(3);

		static public readonly BypassVow Four =  new BypassVow(4);
		static public readonly BypassVow Five =  new BypassVow(5);
		static public readonly BypassVow Six =  new BypassVow(6);
		static public readonly BypassVow Seven =  new BypassVow(7);

		static public readonly BypassVow Eight =  new BypassVow(8);
		static public readonly BypassVow Nine =  new BypassVow(9);
		static public readonly BypassVow Ten =  new BypassVow(10);
		static public readonly BypassVow Eleven =  new BypassVow(11);

		static public readonly BypassVow Twelve =  new BypassVow(12);
		static public readonly BypassVow Thirteen =  new BypassVow(13);
		static public readonly BypassVow Fouteen =  new BypassVow(14);
		static public readonly BypassVow Fifteen =  new BypassVow(15);

		static public readonly BypassVow Sixteen =  new BypassVow(16);
		static public readonly BypassVow Seventeen =  new BypassVow(17);
		static public readonly BypassVow Eighteen =  new BypassVow(18);
		static public readonly BypassVow Nineteen =  new BypassVow(19);

		static public readonly BypassVow Twenty =  new BypassVow(20);



		static public implicit operator BigInteger(BypassVow num) {
			return num.eeByRef;
		}

		static public implicit operator BypassVow(byte num) {
			return new BypassVow(num);
		}

		static public implicit operator BypassVow(ushort num) {
			return new BypassVow(num);
		}
		static public implicit operator BypassVow(uint num) {
			return new BypassVow(num);
		}

		static public implicit operator BypassVow(ulong num) {
			return new BypassVow(num);
		}

		static public explicit operator BypassVow(BigInteger bigint) {
			return  Of(ref bigint);
		}

		static public explicit operator BypassVow(int bigint) {
			return Of(bigint);
		}
		static public explicit operator BypassVow(long bigint) {
			return Of(bigint);
		}



		//from base is not allowed

		static public BypassVow OvInteface( nilnul._num_.EeByRefI num)
		{
			switch (num)
			{
				case BypassVow n:
					return n;
				default:

					return new BypassVow(num.eeByRef);  //no need to check
					break;
			}
		}

		#region re

		static public bool operator ==(BypassVow a, BypassVow b) {
			return a.eeByRef ==b.eeByRef;
		}
		static public bool operator !=(BypassVow a, BypassVow b)
		{
			return !(a == b);
		}

		static public bool operator ==(BypassVow a, uint b) {
			return a.eeByRef ==b;
		}
		static public bool operator !=(BypassVow a, uint b)
		{
			return !(a == b);
		}
		static public bool operator ==(BypassVow a, int b) {
			return a.eeByRef ==b;
		}

		static public bool operator !=(BypassVow a, int b)
		{
			return !(a == b);
		}


		static public bool operator ==(uint b, BypassVow a)
		{
			return a.eeByRef == b;
		}
		static public bool operator !=(uint b, BypassVow a)
		{
			return !(a == b);
		}

		static public bool operator >=(BypassVow a, BypassVow b) {
			return a.eeByRef >=b.eeByRef;
		}
		static public bool operator <=(BypassVow a, BypassVow b) {
			return a.eeByRef<=b.eeByRef;
		}

		static public bool operator >=(BypassVow a, uint b) {
			return a.eeByRef>=b;
		}
		static public bool operator <=(BypassVow a, uint b) {
			return a.eeByRef<=b;
		}
		static public bool operator >=(BypassVow a, long b) {
			return a.eeByRef>=b;
		}
		static public bool operator <=(BypassVow a, long b) {
			return a.eeByRef<=b;
		}

		static public bool operator >=(BypassVow a, ulong b) {
			return a.eeByRef>=b;
		}
		static public bool operator <=(BypassVow a, ulong b) {
			return a.eeByRef<=b;
		}

		static public bool operator >=(  BypassVow a, _num_.EeByRefI b) {
			return a.eeByRef >=b.eeByRef;
		}
		static public bool operator <=(BypassVow a, _num_.EeByRefI b) {
			return a.eeByRef<=b.eeByRef;
		}
		static public bool operator >=( _num_.EeByRefI b, BypassVow a) {
			return b.eeByRef>=a.eeByRef;
		}

		static public bool operator <=( _num_.EeByRefI b, BypassVow a) {
			return b.eeByRef <=a.eeByRef;
		}


		static public bool operator >(BypassVow a, BypassVow b) {
			return a.eeByRef>b.eeByRef;
		}
		static public bool operator >(BypassVow a, _num_.EeByRefI b) {
			return a.eeByRef>b.eeByRef;
		}
		static public bool operator <(BypassVow a, _num_.EeByRefI b) {
			return a.eeByRef<b.eeByRef;
		}


		static public bool operator >(BypassVow a, uint b) {
			return a.eeByRef>b;
		}
		static public bool operator <(BypassVow a, BypassVow b) {
			return a.eeByRef<b.eeByRef;
		}
		static public bool operator <(BypassVow a, uint b) {
			return a.eeByRef<b;
		}
		#endregion


		#region op

		#region unary

		static public BypassVow operator ++(  BypassVow a) {
			
			return new BypassVow( a.eeByRef+1 ); /*Because BigInteger objects are immutable, the Increment operator creates a new BigInteger object whose value is one more than the BigInteger object represented by value. Therefore, repeated calls to Increment may be expensive.*/
		}

		static public BypassVow operator --(  BypassVow a) {
			return Of(a.eeByRef-1);
		}
		#endregion

		static public BypassVow operator -(BypassVow a, int b) {
			return Of(a.eeByRef-b);
		}


		static public BypassVow operator +(BypassVow a, int b) {
			return Of(a.eeByRef+b);
		}

		static public BypassVow operator +(BypassVow a, BypassVow b) {
			return new BypassVow(a.eeByRef+b.eeByRef);
		}
		static public BypassVow operator *(BypassVow a, BypassVow b) {
			return new BypassVow(a.eeByRef*b.eeByRef);
		}
		static public BypassVow operator %(BypassVow a, uint b) {
			return new BypassVow( a.eeByRef%b );
		}

		static public BigInteger operator /(BypassVow a, int b) {
			return Of( a.eeByRef / b );
		}
		static public BypassVow operator /(BypassVow a, uint b) {
			return  new BypassVow ( a.eeByRef/b );
		}




		#endregion


		public bool Equals(BypassVow other)
		{
			return other != null &&
				   eeByRef.Equals(other.eeByRef);
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as BypassVow);
		}


		public override int GetHashCode()
		{
			return  eeByRef.GetHashCode();
		}
	}
}
