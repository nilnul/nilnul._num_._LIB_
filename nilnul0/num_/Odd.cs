using nilnul._num.bigint.be_.natural.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_
{
	public class Odd :
		nilnul.num.be_.odd.vow.Ee_ofByRef
		,
		nilnul.NumI1
		,
		nilnul._num_.asInteger_.RetRefI, IEquatable<Odd>
	{
		public ref BigInteger integerByRef =>ref base.integer;

		public Odd(nilnul.Num_byRef num):base(num)
		{

		}
		public Odd(BigInteger num):this(new Num_byRef(num))
		{

		}
		public Odd(nilnul.num_.Positive1 x):this(x.en)
		{

		}


		static public explicit operator Odd(int a) {
			return new Odd(a);
		}


		static public implicit operator BigInteger(Odd a) {
			return a.integerByRef;
		}
		static public implicit operator Num1(Odd a) {
			return new Num1(a.integerByRef);
		}

		static public explicit operator Odd(Num1 a) {
			return new Odd(a);
		}

		static public explicit operator long(Odd uinteger)
		{
			return (long)(uinteger.integerByRef);
		}


		static public bool operator ==(Odd a, int b)
		{

			return a.integerByRef == b;

		}

		static public bool operator ==(Odd a, Odd b)
		{

			return a.integerByRef == b.integerByRef;

		}
		static public bool operator !=(Odd a, Odd b)
		{

			return ! (a==b );

		}

		static public bool operator !=(Odd a, int b)
		{

			return a.integerByRef != b;

		}

		public En toBigint()
		{
			return new En(
				integerByRef
			);
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as Odd);
		}

		public bool Equals(Odd other)
		{
			return other != null &&
				   integerByRef.Equals(other.integerByRef);
		}

		public override int GetHashCode()
		{
			return 12620337 + integerByRef.GetHashCode();
		}
	}
}
