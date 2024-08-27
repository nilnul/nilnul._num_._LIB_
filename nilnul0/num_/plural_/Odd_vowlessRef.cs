using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be_.natural.vow;

namespace nilnul.num_.plural_
{
	public class Odd_vowlessRef
		:
		 IEquatable<Odd_vowlessRef>
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
		private Odd_vowlessRef(ref BigInteger integer)
		{
			_bigint =  integer;

		}

		private Odd_vowlessRef(BigInteger integer):this(ref integer) {

		}


		static public Odd_vowlessRef Of(
			ref BigInteger bigInteger
		)
		{
			nilnul._num.bigint.be_.plural_.odd.Vow.Singleton.vow(ref bigInteger);

			return new Odd_vowlessRef(ref bigInteger);
		}
		static public Odd_vowlessRef Of(
			 BigInteger bigInteger
		)
		{
			return Of(ref bigInteger);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="i">expect a literal value, not a var, cuz we copy the value into our field, making the var's space wasted</param>
		static public Odd_vowlessRef Of(int i=3)
		{
			return Of((BigInteger)i);
		}


		static public readonly Odd_vowlessRef Three = new Odd_vowlessRef(3);
		static public readonly Odd_vowlessRef Five = new Odd_vowlessRef(5);
		static public readonly Odd_vowlessRef Seven = new Odd_vowlessRef(7);

		static public readonly Odd_vowlessRef Nine = new Odd_vowlessRef(9);
		static public readonly Odd_vowlessRef Eleven = new Odd_vowlessRef(11);
		static public readonly Odd_vowlessRef Thirteen = new Odd_vowlessRef(13);
		static public readonly Odd_vowlessRef Fifteen = new Odd_vowlessRef(15);


		static public readonly Odd_vowlessRef Seventeen = new Odd_vowlessRef(17);
		static public readonly Odd_vowlessRef Nineteen = new Odd_vowlessRef(19);


		static public implicit operator BigInteger(Odd_vowlessRef num) {
			return num.eeByRef;
		}

		static public explicit operator Odd_vowlessRef(byte num) {
			return  Of(num);
		}

		static public explicit operator Odd_vowlessRef(ushort num) {
			return  Of(num);
		}
		static public explicit operator Odd_vowlessRef(uint num) {
			return Of(num);
		}

		static public explicit operator Odd_vowlessRef(ulong num) {
			return Of(num);
		}

		static public explicit operator Odd_vowlessRef(BigInteger bigint) {
			return  Of(ref bigint);
		}

		static public explicit operator Odd_vowlessRef(int bigint) {
			return Of(bigint);
		}
		static public explicit operator Odd_vowlessRef(long bigint) {
			return Of(bigint);
		}




		static public Odd_vowlessRef OvInteface( nilnul._num_.EeByRefI num)
		{
			switch (num)
			{
				case Odd_vowlessRef n:
					return n;
				default:

					return  Of(num.eeByRef);  
					break;
			}
		}

		#region re

		static public bool operator ==(Odd_vowlessRef a, Odd_vowlessRef b) {
			return a.eeByRef ==b.eeByRef;
		}
		static public bool operator !=(Odd_vowlessRef a, Odd_vowlessRef b)
		{
			return !(a == b);
		}

		static public bool operator ==(Odd_vowlessRef a, uint b) {
			return a.eeByRef ==b;
		}
		static public bool operator !=(Odd_vowlessRef a, uint b)
		{
			return !(a == b);
		}
		static public bool operator ==(Odd_vowlessRef a, int b) {
			return a.eeByRef ==b;
		}

		static public bool operator !=(Odd_vowlessRef a, int b)
		{
			return !(a == b);
		}


		static public bool operator ==(uint b, Odd_vowlessRef a)
		{
			return a.eeByRef == b;
		}
		static public bool operator !=(uint b, Odd_vowlessRef a)
		{
			return !(a == b);
		}

		static public bool operator >=(Odd_vowlessRef a, Odd_vowlessRef b) {
			return a.eeByRef >=b.eeByRef;
		}
		static public bool operator <=(Odd_vowlessRef a, Odd_vowlessRef b) {
			return a.eeByRef<=b.eeByRef;
		}

		static public bool operator >=(Odd_vowlessRef a, uint b) {
			return a.eeByRef>=b;
		}
		static public bool operator <=(Odd_vowlessRef a, uint b) {
			return a.eeByRef<=b;
		}
		static public bool operator >=(Odd_vowlessRef a, long b) {
			return a.eeByRef>=b;
		}
		static public bool operator <=(Odd_vowlessRef a, long b) {
			return a.eeByRef<=b;
		}

		static public bool operator >=(Odd_vowlessRef a, ulong b) {
			return a.eeByRef>=b;
		}
		static public bool operator <=(Odd_vowlessRef a, ulong b) {
			return a.eeByRef<=b;
		}

		static public bool operator >=(  Odd_vowlessRef a, _num_.EeByRefI b) {
			return a.eeByRef >=b.eeByRef;
		}
		static public bool operator <=(Odd_vowlessRef a, _num_.EeByRefI b) {
			return a.eeByRef <=b.eeByRef;
		}
		static public bool operator >=( _num_.EeByRefI b, Odd_vowlessRef a) {
			return b.eeByRef>=a.eeByRef;
		}

		static public bool operator <=( _num_.EeByRefI b, Odd_vowlessRef a) {
			return b.eeByRef <=a.eeByRef;
		}


		static public bool operator >(Odd_vowlessRef a, Odd_vowlessRef b) {
			return a.eeByRef>b.eeByRef;
		}
		static public bool operator <(Odd_vowlessRef a, Odd_vowlessRef b) {
			return a.eeByRef<b.eeByRef;
		}

		static public bool operator >(Odd_vowlessRef a, _num_.EeByRefI b) {
			return a.eeByRef>b.eeByRef;
		}
		static public bool operator <(Odd_vowlessRef a, _num_.EeByRefI b) {
			return a.eeByRef<b.eeByRef;
		}


		static public bool operator >(Odd_vowlessRef a, uint b) {
			return a.eeByRef>b;
		}
		static public bool operator <(Odd_vowlessRef a, uint b) {
			return a.eeByRef<b;
		}
		#endregion


		#region op

	


	

		static public Odd_vowlessRef operator *(Odd_vowlessRef a, Odd_vowlessRef b) {
			return new Odd_vowlessRef(a.eeByRef*b.eeByRef);
		}
	



		#endregion


		public bool Equals(Odd_vowlessRef other)
		{
			return other != null &&
				   eeByRef.Equals(other.eeByRef);
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as Odd_vowlessRef);
		}


		public override int GetHashCode()
		{
			return  eeByRef.GetHashCode();
		}
	}
}
