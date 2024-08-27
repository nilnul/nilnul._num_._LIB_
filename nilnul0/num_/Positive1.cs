using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be_.natural.vow;

namespace nilnul.num_
{

	[Obsolete(nameof(num_.ref_.vowless_.Positive) + " is more performant")]

	public class Positive1 : nilnul._num.bigint.be_.positive.vow.En
		,
		nilnul.NumI1
	{

		public Positive1(BigInteger x) : base(x)
		{
		}

		public Positive1(NumI1 num):base(num.toBigint())
		{
		}
		public Positive1(Num1 num):base(num.toBigint())
		{
		}

		static public implicit operator Num1(Positive1 x) {
			return new Num1( x.en);
		}

		static public implicit operator Positive1(Plural x) {
			return new Positive1( x);
		}
		static public explicit operator int(Positive1 x) {
			return (int)( x.en);
		}
		static public explicit operator BigInteger(Positive1 x) {
			return  x.en;
		}

		static public explicit operator Positive1(int x) {
			return new Positive1( x);
		}
		static public Positive1 operator ++(Positive1 x)
		{
			return new Positive1(x.en+1);
		}

		static public Positive1  operator *(Positive1 x, Positive1 y) {
			return new Positive1( x.en *y.en);
		}

		static public bool  operator ==(Positive1 x, Positive1 y) {
			return x.en ==y.en;
		}
		static public bool  operator !=(Positive1 x, Positive1 y) {
			return !(x ==y);
		}
		static public bool  operator ==(Positive1 x, int y) {
			return x.en ==y;
		}
		static public bool  operator !=(Positive1 x, int y) {
			return !(x ==y);
		}

		static public bool  operator ==( int x1, Positive1 y) {
			return y ==x1;
		}
		static public bool  operator !=( int x1, Positive1 y) {
			return !( x1==y);
		}


		static public bool  operator <=(Positive1 x, Positive1 y) {
			return x.en<=y.en;
		}
		static public bool  operator >=(Positive1 x, Positive1 y) {
			return x.en>=y.en;
		}

		static public nilnul.Num1  Decrease(Positive1 x) {
			return new Num1(x.en-1) ;
		}


		static public Positive1 CreateOne() {
			return new Positive1(1);
		}

		public En toBigint()
		{
			return new En( this.en);
		}
	}
}
