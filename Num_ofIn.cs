using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be_.natural.vow;

namespace nilnul
{
	/// due to the immutability of BigInteger, boxing an outside reference is safe. But we cannot have a field that is a ref as the referenced might be garbage collected and break our reference.
	/// <summary>
	/// box a bigint directly rather than thru a vowee like <see cref="nilnul._num.bigint.be_.natural.vow.Ee_byRef"/> in order to internally bypass some check. the bigint is immutable, so this class just assures the caller that value is natural, whileas this class cannot alter the boxed.
	/// </summary>
	/// <remarks>
	/// due to the vowing process, for performance reasons, use the BigInteger for computation. This class is mainly used to transfer an assurance when communicating a parameter.
	/// </remarks>
	public class Num_ofIn
		:
		 IEquatable<Num_ofIn>
		,
		INum
		,
		nilnul.obj.vow._ee_.RetRefI<BigInteger>
		,
		_num_.EeByRefI
		,
		NumI1
		
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
		private Num_ofIn(in BigInteger integer)
		{
			_bigint =  integer;

		}
		private Num_ofIn(BigInteger integer):this(in integer) {

		}

		public override string ToString()
		{
			return this._bigint.ToString();
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


		static public Num_ofIn Of(
			in BigInteger bigInteger
		)
		{
			nilnul._num.bigint.be_.natural.vow_.OfIn.Singleton.vow(in bigInteger);

			return new Num_ofIn(in bigInteger);
		}
		/// <summary>
		/// used only when no refVar is available, for example, if an expr is transferred in.
		/// </summary>
		/// <param name="bigInteger"></param>
		/// <returns></returns>
		static public Num_ofIn Of(
			 BigInteger bigInteger
		)
		{
			return Of(in bigInteger);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="i">expect a literal value, not a var, cuz we copy the value into our field, making the var's space wasted</param>
		static public Num_ofIn Of(int i=0)
		{
			return Of((BigInteger)i);
			BigInteger x = i;
			return Of(in x);
		}



		static public readonly  Num_ofIn Nil =  new Num_ofIn(0);
		static public readonly Num_ofIn One =  new Num_ofIn(1);
		static public readonly Num_ofIn Two =  new Num_ofIn(2);
		static public readonly Num_ofIn Three =  new Num_ofIn(3);

		static public readonly Num_ofIn Four =  new Num_ofIn(4);
		static public readonly Num_ofIn Five =  new Num_ofIn(5);
		static public readonly Num_ofIn Six =  new Num_ofIn(6);
		static public readonly Num_ofIn Seven =  new Num_ofIn(7);

		static public readonly Num_ofIn Eight =  new Num_ofIn(8);
		static public readonly Num_ofIn Nine =  new Num_ofIn(9);
		static public readonly Num_ofIn Ten =  new Num_ofIn(10);
		static public readonly Num_ofIn Eleven =  new Num_ofIn(11);

		static public readonly Num_ofIn Twelve =  new Num_ofIn(12);
		static public readonly Num_ofIn Thirteen =  new Num_ofIn(13);
		static public readonly Num_ofIn Fouteen =  new Num_ofIn(14);
		static public readonly Num_ofIn Fifteen =  new Num_ofIn(15);

		static public readonly Num_ofIn Sixteen =  new Num_ofIn(16);
		static public readonly Num_ofIn Seventeen =  new Num_ofIn(17);
		static public readonly Num_ofIn Eighteen =  new Num_ofIn(18);
		static public readonly Num_ofIn Nineteen =  new Num_ofIn(19);

		static public readonly Num_ofIn Twenty =  new Num_ofIn(20);



		static public implicit operator BigInteger(Num_ofIn num) {
			return num.eeByRef;
		}

		static public implicit operator Num_ofIn(byte num) {
			return new Num_ofIn(num);
		}

		static public implicit operator Num_ofIn(ushort num) {
			return new Num_ofIn(num);
		}
		static public implicit operator Num_ofIn(uint num) {
			return new Num_ofIn(num);
		}

		static public implicit operator Num_ofIn(ulong num) {
			return new Num_ofIn(num);
		}

		static public explicit operator Num_ofIn(BigInteger bigint) {
			return  Of(in bigint);
		}

		static public explicit operator Num_ofIn(int bigint) {
			return Of(bigint);
		}
		static public explicit operator Num_ofIn(long bigint) {
			return Of(bigint);
		}



		//from base is not allowed

		static public Num_ofIn OvInteface( nilnul._num_.EeByRefI num)
		{
			switch (num)
			{
				case Num_ofIn n:
					return n;
				default:

					return new Num_ofIn(num.eeByRef);  //no need to check
					break;
			}
		}

		#region re

		static public bool operator ==(Num_ofIn a, Num_ofIn b) {
			return a.eeByRef ==b.eeByRef;
		}
		static public bool operator !=(Num_ofIn a, Num_ofIn b)
		{
			return !(a == b);
		}

		static public bool operator ==(Num_ofIn a, uint b) {
			return a.eeByRef ==b;
		}
		static public bool operator !=(Num_ofIn a, uint b)
		{
			return !(a == b);
		}
		static public bool operator ==(Num_ofIn a, int b) {
			return a.eeByRef ==b;
		}

		static public bool operator !=(Num_ofIn a, int b)
		{
			return !(a == b);
		}


		static public bool operator ==(uint b, Num_ofIn a)
		{
			return a.eeByRef == b;
		}
		static public bool operator !=(uint b, Num_ofIn a)
		{
			return !(a == b);
		}

		static public bool operator >=(Num_ofIn a, Num_ofIn b) {
			return a.eeByRef >=b.eeByRef;
		}
		static public bool operator <=(Num_ofIn a, Num_ofIn b) {
			return a.eeByRef<=b.eeByRef;
		}

		static public bool operator >=(Num_ofIn a, uint b) {
			return a.eeByRef>=b;
		}
		static public bool operator <=(Num_ofIn a, uint b) {
			return a.eeByRef<=b;
		}
		static public bool operator >=(Num_ofIn a, long b) {
			return a.eeByRef>=b;
		}
		static public bool operator <=(Num_ofIn a, long b) {
			return a.eeByRef<=b;
		}

		static public bool operator >=(Num_ofIn a, ulong b) {
			return a.eeByRef>=b;
		}
		static public bool operator <=(Num_ofIn a, ulong b) {
			return a.eeByRef<=b;
		}

		static public bool operator >=(  Num_ofIn a, _num_.EeByRefI b) {
			return a.eeByRef >=b.eeByRef;
		}
		static public bool operator <=(Num_ofIn a, _num_.EeByRefI b) {
			return a.eeByRef<=b.eeByRef;
		}
		static public bool operator >=( _num_.EeByRefI b, Num_ofIn a) {
			return b.eeByRef>=a.eeByRef;
		}

		static public bool operator <=( _num_.EeByRefI b, Num_ofIn a) {
			return b.eeByRef <=a.eeByRef;
		}


		static public bool operator >(Num_ofIn a, Num_ofIn b) {
			return a.eeByRef>b.eeByRef;
		}
		static public bool operator >(Num_ofIn a, _num_.EeByRefI b) {
			return a.eeByRef>b.eeByRef;
		}
		static public bool operator <(Num_ofIn a, _num_.EeByRefI b) {
			return a.eeByRef<b.eeByRef;
		}


		static public bool operator >(Num_ofIn a, uint b) {
			return a.eeByRef>b;
		}
		static public bool operator <(Num_ofIn a, Num_ofIn b) {
			return a.eeByRef<b.eeByRef;
		}
		static public bool operator <(Num_ofIn a, uint b) {
			return a.eeByRef<b;
		}
		#endregion


		#region op

		#region unary

		static public Num_ofIn operator ++(  Num_ofIn a) {
			
			return new Num_ofIn( a.eeByRef+1 ); /*Because BigInteger objects are immutable, the Increment operator creates a new BigInteger object whose value is one more than the BigInteger object represented by value. Therefore, repeated calls to Increment may be expensive.*/
		}

		static public Num_ofIn operator --(  Num_ofIn a) {
			return Of(a.eeByRef-1);
		}
		#endregion

		static public Num_ofIn operator -(Num_ofIn a, int b) {
			return Of(a.eeByRef-b);
		}


		static public Num_ofIn operator +(Num_ofIn a, int b) {
			return Of(a.eeByRef+b);
		}

		static public Num_ofIn operator +(Num_ofIn a, Num_ofIn b) {
			return new Num_ofIn(a.eeByRef+b.eeByRef);
		}
		static public Num_ofIn operator *(Num_ofIn a, Num_ofIn b) {
			return new Num_ofIn(a.eeByRef*b.eeByRef);
		}
		static public Num_ofIn operator %(Num_ofIn a, uint b) {
			return new Num_ofIn( a.eeByRef%b );
		}

		static public BigInteger operator /(Num_ofIn a, int b) {
			return Of( a.eeByRef / b );
		}
		static public Num_ofIn operator /(Num_ofIn a, uint b) {
			return  new Num_ofIn ( a.eeByRef/b );
		}




		#endregion


		public bool Equals(Num_ofIn other)
		{
			return other != null &&
				   eeByRef.Equals(other.eeByRef);
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as Num_ofIn);
		}


		public override int GetHashCode()
		{
			return  eeByRef.GetHashCode();
		}

		public En toBigint()
		{
			return new En( this.eeByRef );
			//throw new NotImplementedException();
		}
	}
}
