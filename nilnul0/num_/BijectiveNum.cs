using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_
{
	/// <summary>
	/// for example:
	///		one base
	///			""
	///			"1"
	///			"11"
	///		two base:
	///			""
	///			"1"
	///			"2"
	///			""
	///		26Base using capital letters:
	///			""
	///			"A"
	///			"Z"
	///			"AA"
	/// </summary>
	/// <remarks>
	/// alias:
	///		bijective
	///		biject
	///		
	/// </remarks>
	public interface IBiject {

	}
	/// <summary>
	/// little endian
	/// But the txt is bigEndian. take care: A, B, AA, AB; and "" is zero
	/// </summary>
	public class BijectiveNum:IBiject
	{

		private nilnul.num_.Positive _root;

		public nilnul.num_.Positive root
		{
			get { return _root; }
			set { _root = value; }
		}
		/// <summary>
		/// little endian
		/// </summary>
		private  nilnul.num_.positive.str_.EnumerableI _digits;

		public nilnul.num_.positive.str_.EnumerableI digits
		{
			get { return _digits; }
			set { _digits = value; }
		}


		public BijectiveNum(
			nilnul.num_.Positive root
			,
			nilnul.num_.positive.str_.EnumerableI digits
			
		)
		{

			nilnul.obj.vow_.True.Vow(

				digits.toArr().All(x=>x <=root)
			);

			_root = root;
			_digits = digits;
		}


		public BijectiveNum(
			nilnul.num_._radix.Root root
			,
			nilnul.num_.positive.str_.EnumerableI digits
			
		)
		{

			nilnul.obj.vow_.True.Vow(

				digits.All(x=>x <=root.radic)
			);

			_root = root.radic;
			_digits = digits;
		}



		public nilnul.Num toNum() {
			return toNum_byBigendianShift();
		}

		public nilnul.Num toNum_byPow() {
			return nilnul.num.accumulate_._SumX.Eval(
				digits.Select(
					(x, i) => x * nilnul.num.combine_._PowX.Do_basePlural_indexNonNeg(root.val, i)
				).Select(y => new Num(y))
			);
		}


		public nilnul.Num toNum_byBigendianShift() {
			BigInteger r = 0;
			foreach (var item in _digits.Reverse())
			{
				r *= this.root;
				r += item;// * this.root;
			}

			return new Num( r);
		}


	}
}
