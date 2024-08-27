using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.str_;

namespace nilnul.num_
{
	/// <summary>
	/// 012345670<sub>16</sub>
	/// </summary>
	public class Radix2 : RadixI
	{

		private nilnul.num_.Plural1 _basis;

		public nilnul.num_.Plural1 basis
		{
			get { return _basis; }
			set { _basis = value; }
		}

		/// <summary>
		/// little endian ===== most significant last
		/// </summary>
		private nilnul.nums_.ListOfClass _digits;

		public nilnul.nums_.ListOfClass digits
		{
			get { return _digits; }
			set { _digits = value; }
		}


		public IEnumerable<Num_ofIn> gits {
			get => _digits.Select(g=>  Num_ofIn.Of(g));
		}

		public ref_.vowless_.Plural radic =>  ref_.vowless_.Plural.Of( _basis.en);

		public Radix2(
			nilnul.num_.Plural1 root
			,
			nilnul.nums_.ListOfClass digits

		)
		{

			nilnul.obj.vow_.True.Vow(

				digits.All(x => x.toBigint().en < root)
			);

			_basis = root;
			_digits = digits;
		}


		public Radix2(
			nilnul.num_.Plural1 root
			,
			IEnumerable<Num1> digits

		) : this(root, new nums_.ListOfClass(digits))
		{


		}

		public Radix2(
			BigInteger root
			,
			IEnumerable<Num1> digits

		) : this(
			new Plural1(
			root
			),

			new nums_.ListOfClass(digits))
		{


		}

		public Radix2(
			BigInteger root
			,
			IEnumerable<BigInteger> digits

		) : this(
			new Plural1(
			root
			),

			new nums_.ListOfClass(digits))
		{


		}

		public Radix2(
			BigInteger root
			,
			IEnumerable<int> digits

		) : this(
			new Plural1(
			root
			),

			new nums_.ListOfClass(digits))
		{


		}


		public void trimInsignificants()
		{
			_digits = new nums_.ListOfClass(
				(_digits as IEnumerable<Num1>).Reverse().SkipWhile(x => x == 0).Reverse()
			);

		}

		public nilnul.Num1 toNum()
		{
			return nilnul.num.accumulate_._SumX.Eval1(
				digits.Select(
					(x, i) => x *
					//nilnul.num.combine_._PowX.Do_basePlural_indexNonNeg
					nilnul.num.op_.binary_._PowX._Op_basePlural_indexNonNeg
					(basis.en, i)
				).Select(y => new Num1(y))
			);
		}

		public string _phase_assumeValid(char[] _chars)
		{
			return radix._PhraseX._Phrase_1valid(this, _chars);

			//return string.Join(
			//	"",
			//	this.digits.Select(x => _chars[(int)(x.en)]).Reverse()
			//);
		}
		public override string ToString()
		{
			return radix._PhraseX.Phrase(this);
		}
		public IEnumerable<char> _gits_assumeValid(char[] _chars)
		{

			return radix._phrase._Insignificant1stX._AsChars_1valid(this,_chars);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="root">as radic</param>
		/// <param name="x">
		/// the number to convert to radix;
		/// </param>
		/// <returns></returns>
		///
		[Obsolete(nameof(radix.of_._OfNumX.Of))]
		static public Radix2 Of(nilnul.num_.Plural root, nilnul.Num1 x)
		{
			return radix.of_._OfNumX.Of(root, x);
		
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="root">par0 is radic;</param>
		/// <param name="x">par1 is num</param>
		/// <returns></returns>
		///
		[Obsolete(nameof(radix.of_._OfNumX.Of))]
		static public Radix2 OfRadic1num(nilnul.num_.Plural root, BigInteger x)
		{
			return Of(root, new Num1(x));
		}

		public BigInteger toBigint()
		{
			BigInteger weight = 1;

			BigInteger r = 0;

			for (int i = 0; i < digits.Count; i++)
			{
				r += digits[i] * weight;
				weight *= radic.eeByRef;
			}
			return r;
		}

		static public bool operator ==(Radix2 radix, uint i)
		{
			return radix.toNum() == i;
		}
		static public bool operator !=(Radix2 radix, uint i)
		{
			return !(radix == i);
		}

		static public bool operator ==(uint i, Radix2 radix)
		{
			return radix == i;
		}
		static public bool operator !=(uint i, Radix2 radix)
		{
			return !(i == radix);
		}



	}
}
