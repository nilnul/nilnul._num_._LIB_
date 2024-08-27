using nilnul._num.bigint.be_.natural.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_
{
	[Obsolete()]
	public class Even :
		nilnul.num.be_.even.vow.Ee_ofByRef
		,
		nilnul.NumI1
		,
		nilnul._num_.asInteger_.RetRefI, IEquatable<Even>
	{
		public ref BigInteger integerByRef => ref base.integer;

		public Even(nilnul.Num_byRef num):base(num)
		{

		}
		public Even(BigInteger num):this(new Num_byRef(num))
		{

		}
		public Even(nilnul.num_.Positive1 x):this(x.en)
		{

		}


		static public explicit operator Even(int a) {
			return new Even(a);
		}


		static public implicit operator BigInteger(Even a) {
			return a.integerByRef;
		}
		static public implicit operator Num1(Even a) {
			return new Num1(a.integerByRef);
		}

		static public explicit operator Even(Num1 a) {
			return new Even(a);
		}

		static public explicit operator long(Even uinteger)
		{
			return (long)(uinteger.integerByRef);
		}


		static public bool operator ==(Even a, int b)
		{

			return a.integerByRef == b;

		}

		static public bool operator ==(Even a, Even b)
		{

			return a.integerByRef == b.integerByRef;

		}
		static public bool operator !=(Even a, Even b)
		{

			return ! (a==b );

		}

		static public bool operator !=(Even a, int b)
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
			return Equals(obj as Even);
		}

		public bool Equals(Even other)
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
