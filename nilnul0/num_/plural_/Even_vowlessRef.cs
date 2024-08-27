using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be_.natural.vow;

namespace nilnul.num_.plural_
{
	public class Even_vowlessRef
		:
		 IEquatable<Even_vowlessRef>
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
		private Even_vowlessRef(ref BigInteger integer)
		{
			_bigint =  integer;

		}

		private Even_vowlessRef(BigInteger integer):this(ref integer) {

		}


		static public Even_vowlessRef Of(
			ref BigInteger bigInteger
		)
		{
			nilnul._num.bigint.be_.plural_.even.Vow.Singleton.vow(ref bigInteger);

			return new Even_vowlessRef(ref bigInteger);
		}
		static public Even_vowlessRef Of(
			 BigInteger bigInteger
		)
		{
			return Of(ref bigInteger);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="i">expect a literal value, not a var, cuz we copy the value into our field, making the var's space wasted</param>
		static public Even_vowlessRef Of(int i=2)
		{
			return Of((BigInteger)i);
		}


		static public readonly Even_vowlessRef Two =  new Even_vowlessRef(2);
		static public readonly Even_vowlessRef Four =  new Even_vowlessRef(4);
		static public readonly Even_vowlessRef Six =  new Even_vowlessRef(6);

		static public readonly Even_vowlessRef Eight =  new Even_vowlessRef(8);
		static public readonly Even_vowlessRef Ten =  new Even_vowlessRef(10);
		static public readonly Even_vowlessRef Twelve =  new Even_vowlessRef(12);
		static public readonly Even_vowlessRef Fouteen =  new Even_vowlessRef(14);


		static public readonly Even_vowlessRef Sixteen =  new Even_vowlessRef(16);
		static public readonly Even_vowlessRef Eighteen =  new Even_vowlessRef(18);

		static public readonly Even_vowlessRef Twenty =  new Even_vowlessRef(20);



		static public implicit operator BigInteger(Even_vowlessRef num) {
			return num.eeByRef;
		}

		static public explicit operator Even_vowlessRef(byte num) {
			return  Of(num);
		}

		static public explicit operator Even_vowlessRef(ushort num) {
			return  Of(num);
		}
		static public explicit operator Even_vowlessRef(uint num) {
			return Of(num);
		}

		static public explicit operator Even_vowlessRef(ulong num) {
			return Of(num);
		}

		static public explicit operator Even_vowlessRef(BigInteger bigint) {
			return  Of(ref bigint);
		}

		static public explicit operator Even_vowlessRef(int bigint) {
			return Of(bigint);
		}
		static public explicit operator Even_vowlessRef(long bigint) {
			return Of(bigint);
		}




		static public Even_vowlessRef OvInteface( nilnul._num_.EeByRefI num)
		{
			switch (num)
			{
				case Even_vowlessRef n:
					return n;
				default:

					return  Of(num.eeByRef);  
					break;
			}
		}

		#region re

		static public bool operator ==(Even_vowlessRef a, Even_vowlessRef b) {
			return a.eeByRef ==b.eeByRef;
		}
		static public bool operator !=(Even_vowlessRef a, Even_vowlessRef b)
		{
			return !(a == b);
		}

		static public bool operator ==(Even_vowlessRef a, uint b) {
			return a.eeByRef ==b;
		}
		static public bool operator !=(Even_vowlessRef a, uint b)
		{
			return !(a == b);
		}
		static public bool operator ==(Even_vowlessRef a, int b) {
			return a.eeByRef ==b;
		}

		static public bool operator !=(Even_vowlessRef a, int b)
		{
			return !(a == b);
		}


		static public bool operator ==(uint b, Even_vowlessRef a)
		{
			return a.eeByRef == b;
		}
		static public bool operator !=(uint b, Even_vowlessRef a)
		{
			return !(a == b);
		}

		static public bool operator >=(Even_vowlessRef a, Even_vowlessRef b) {
			return a.eeByRef >=b.eeByRef;
		}
		static public bool operator <=(Even_vowlessRef a, Even_vowlessRef b) {
			return a.eeByRef<=b.eeByRef;
		}

		static public bool operator >=(Even_vowlessRef a, uint b) {
			return a.eeByRef>=b;
		}
		static public bool operator <=(Even_vowlessRef a, uint b) {
			return a.eeByRef<=b;
		}
		static public bool operator >=(Even_vowlessRef a, long b) {
			return a.eeByRef>=b;
		}
		static public bool operator <=(Even_vowlessRef a, long b) {
			return a.eeByRef<=b;
		}

		static public bool operator >=(Even_vowlessRef a, ulong b) {
			return a.eeByRef>=b;
		}
		static public bool operator <=(Even_vowlessRef a, ulong b) {
			return a.eeByRef<=b;
		}

		static public bool operator >=(  Even_vowlessRef a, _num_.EeByRefI b) {
			return a.eeByRef >=b.eeByRef;
		}
		static public bool operator <=(Even_vowlessRef a, _num_.EeByRefI b) {
			return a.eeByRef <=b.eeByRef;
		}
		static public bool operator >=( _num_.EeByRefI b, Even_vowlessRef a) {
			return b.eeByRef>=a.eeByRef;
		}

		static public bool operator <=( _num_.EeByRefI b, Even_vowlessRef a) {
			return b.eeByRef <=a.eeByRef;
		}


		static public bool operator >(Even_vowlessRef a, Even_vowlessRef b) {
			return a.eeByRef>b.eeByRef;
		}
		static public bool operator <(Even_vowlessRef a, Even_vowlessRef b) {
			return a.eeByRef<b.eeByRef;
		}

		static public bool operator >(Even_vowlessRef a, _num_.EeByRefI b) {
			return a.eeByRef>b.eeByRef;
		}
		static public bool operator <(Even_vowlessRef a, _num_.EeByRefI b) {
			return a.eeByRef<b.eeByRef;
		}


		static public bool operator >(Even_vowlessRef a, uint b) {
			return a.eeByRef>b;
		}
		static public bool operator <(Even_vowlessRef a, uint b) {
			return a.eeByRef<b;
		}
		#endregion


		#region op

		#region unary

	
		#endregion



		static public Even_vowlessRef operator +(Even_vowlessRef a, Even_vowlessRef b) {
			return new Even_vowlessRef(a.eeByRef+b.eeByRef);
		}
	

		static public Even_vowlessRef operator *(Even_vowlessRef a, Even_vowlessRef b) {
			return new Even_vowlessRef(a.eeByRef*b.eeByRef);
		}
	



		#endregion


		public bool Equals(Even_vowlessRef other)
		{
			return other != null &&
				   eeByRef.Equals(other.eeByRef);
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as Even_vowlessRef);
		}


		public override int GetHashCode()
		{
			return  eeByRef.GetHashCode();
		}
	}
}
