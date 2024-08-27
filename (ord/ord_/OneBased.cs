using nilnul.num._ord_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord_
{
	/// <summary>
	/// the tag for the order starts at one:
	/// 1st,2nd,3rd, 4th, 5th,...
	/// </summary>
	/// <remarks>
	/// for index, or numero like <see cref="nilnul.INum"/>, the ord is <see cref="ord_.INumero"/>, or nil based, the ordinal number shall be placed after the type:
	///		eg:
	///			floor 0;
	///			, or floor[0];
	///	for this, the ordinal shall be placed before the type, eg:
	///		1st floor
	///		,or the 1st floor;
	///		,	where "st" means subtract something, which is 1 here.
	///	
	/// </remarks>
	/// eg:
	///		"the row 1 (the second row) of this matrix"
	///		,from https://en.wikipedia.org/wiki/Sparse_matrix
	public class OneBased :
		nilnul.obj.Box1<nilnul.num_.Positive1>
		,
		nilnul.num.OrdI1
		,
		nilnul.num.OrdI2
		,
		IOneBased

	{
		protected OneBased(nilnul.num_.Positive1 val) : base(val)
		{
		}

		public OneBased(nilnul.num.OrdI1 ord):base( 
			new nilnul.num_.Positive1(ord.toNum() +1)
			)
		{

		}

		public OneBased(nilnul.num.OrdI2 ord):base( 
			new nilnul.num_.Positive1(ord.toNum().toBigint().en +1)
			)
		{

		}

		public OneBased(BigInteger _positive):this(new num_.Positive1(_positive) )
		{

		}

		public nilnul.num_.Positive1 boxed1 { get {
				return base.boxed;
			} }

		static public OneBased FroNilBased(nilnul.Num nilBased) {
			return new OneBased(
				new num_.Positive1(
					nilBased +1
				)
			);
		}

		static public OneBased FroOneBased(nilnul.num_.Positive1 oneBased) {
			return new OneBased(
				oneBased
			);
		}
		
		static public OneBased FroOneBased(BigInteger oneBased) {
			return new OneBased(
				oneBased
			);
		}

		//public Num toNum()
		//{

		//	return new Num(this.boxed.en - 1);
		//	throw new NotImplementedException();

		//}

		public Num toNum()
		{


			return new Num1(this.boxed.en - 1);

		}

		NumI1 _ord_.ToBaseZeroI3.toNum()
		{
			return new Num1(this.boxed.en - 1);

		}

		static public  OneBased operator ++(OneBased x) {
			return new OneBased(++ x.boxed);
		}
		static public  OneBased operator --(OneBased x) {
			return new OneBased( new nilnul.num_.Positive1( x.boxed.en -1));
		}

		static public implicit operator OneBased(nilnul.Num num) {
			return new OneBased( new nilnul.num_.Positive1( num +1 ));
		}

		static public bool operator <(OneBased x, OneBased y) {
			return x.toNum() < y.toNum();
		}
		static public bool operator <=(OneBased x, OneBased y) {
			return x.toNum() <= y.toNum();
		}
		static public bool operator >=(OneBased x, OneBased y) {
			return x.toNum() >= y.toNum();
		}

		static public bool operator >(OneBased x, OneBased y) {
			return x.toNum() > y.toNum();
		}
		static public bool operator ==(OneBased x, OneBased y) {
			return x.toNum() == y.toNum();
		}
		static public bool operator !=(OneBased x, OneBased y) {
			return x.toNum() != y.toNum();
		}

		public override string ToString()
		{
			return $"#{base.ToString()}";
		}
	}
}
