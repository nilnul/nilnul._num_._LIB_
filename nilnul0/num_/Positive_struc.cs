using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be_.natural.vow;

namespace nilnul.num_
{
	[Obsolete("Only in newer C# can we have a parameterless ctor, which in old version is invalid as it's initialized to nil that is not positive")]
//	[Obsolete(nameof(num_.ref_.vowless_.Positive) + " is more performant")]

	public struct Positive_struct
		:
		//System.Numerics.BigInteger
		//nilnul._num.bigint.be_.positive.vow.En
		//,
		nilnul.NumI1
		,
		nilnul._num_.AsIntegerI
	{
		private BigInteger _bigint;

		public BigInteger asInteger {
			get {
				// a copy
				return _bigint;
			}
		}

		public Positive_struct(BigInteger x) 
		{
			nilnul._num.bigint.be_.positive.Vow.Singleton.vow(x);
			_bigint = x;
		}

		public Positive_struct(NumI1 num):this(num.toBigint())
		{
		}
		public Positive_struct(Num1 num):this(num.en)
		{
		}
		/////  error
		/////  <summary>
		/////
		///// </summary>
		//public Positive_struct()
		//{
		//	_bigint = 1;

		//}

		static public implicit operator Num1(Positive_struct x) {
			return new Num1( x._bigint);
		}

		static public implicit operator Positive_struct(Plural x) {
			return new Positive_struct( x);
		}
		static public explicit operator int(Positive_struct x) {
			return (int)( x._bigint);
		}
		static public explicit operator BigInteger(Positive_struct x) {
			return  x.asInteger;
		}

		static public explicit operator Positive_struct(int x) {
			return new Positive_struct( x);
		}
		static public Positive_struct operator ++(Positive_struct x)
		{
			return new Positive_struct(x._bigint+1);
		}

		static public Positive_struct  operator *(Positive_struct x, Positive_struct y) {
			return new Positive_struct( x._bigint *y._bigint);
		}

		static public Positive_struct  operator +(Positive_struct x, nilnul.NumI1 y) {
			return new Positive_struct( x._bigint +y.toBigint());
		}

		static public Positive_struct  operator +( nilnul.NumI1 y, Positive_struct x) {
			return new Positive_struct( x._bigint +y.toBigint());
		}

		static public bool  operator ==(Positive_struct x, Positive_struct y) {
			return x._bigint ==y._bigint;
		}
		static public bool  operator !=(Positive_struct x, Positive_struct y) {
			return !(x ==y);
		}
		static public bool  operator ==(Positive_struct x, int y) {
			return x._bigint ==y;
		}
		static public bool  operator !=(Positive_struct x, int y) {
			return !(x ==y);
		}

		static public bool  operator ==( int x1, Positive_struct y) {
			return y ==x1;
		}
		static public bool  operator !=( int x1, Positive_struct y) {
			return !( x1==y);
		}


		static public bool  operator <=(Positive_struct x, Positive_struct y) {
			return x._bigint <=y._bigint;
		}
		static public bool  operator >=(Positive_struct x, Positive_struct y) {
			return x._bigint >=y._bigint;
		}

		static public nilnul.Num1  Decrease(Positive_struct x) {
			return new Num1(x._bigint -1) ;
		}


		static public Positive_struct OneOf() {
			return new Positive_struct(1);
		}

		public En toBigint()
		{
			return new En( _bigint );
			//throw new NotImplementedException();
		}
	}
}
