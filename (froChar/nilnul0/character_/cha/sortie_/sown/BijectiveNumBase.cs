using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using A =  nilnul.character_.cha.sortie_.SownI;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.character_.cha.sortie_.sown
{
	/// <summary>
	/// by eliminating zero char, we eliminate the chance to add a char without change the num lke what we do in prepend 0 to 1 resulting to 01.
	/// </summary>
	public class BijectiveNumBase
	{

		private nilnul.character_.cha.sortie_.SownI _alphabet;

		public  nilnul.character_.cha.sortie_.SownI alphabet
		{
			get { return _alphabet; }
			set
			{
				_alphabet = value;
			}
		}

		public char[] toCharArray() {
			return _alphabet.str.en.ToArray();;
		}

		nilnul.num_.Positive indexOf(char c) {
			return new nilnul.num_.Positive(
				_alphabet.str.en.IndexOf(c) +1	//if not found, this is zero, resulting an exn.
			);
		}

		public char char4one
		{
			get { return _alphabet.str.en.First(); }
		}


		public char digitOf(nilnul.num_.Positive x_leRoot)
		{
			return _alphabet.str.en[(int)x_leRoot - 1];
		}



		public int radical
		{
			get { return _alphabet.str.en.Length; }
			//set { _radical = value; }
		}

		public nilnul.num_.Positive radicalAsPositive
		{
			get { return new nilnul.num_.Positive( _alphabet.str.en.Length); }
			//set { _radical = value; }
		}


		public BijectiveNumBase(A alphabet)
		{
			this.alphabet = alphabet;
		}

		//public BijectiveNumBase(nilnul.character_.cha.sortie_.sown_.Upper singleton)
		//	:this(
		//		 new 
		//		nilnul.character.sortie_.distinctTxt.be_.sown.vow.Ed(singleton.strDistinctPositive.ed.ed) 
		//	)
		//{
		//	;
		//}

		public string alphabetTxt { get {
				return _alphabet.str.en;
			} }


		public nilnul.Num parse_bigEndian(string txt)
		{
			return new nilnul.num_.BijectiveNum(

				radicalAsPositive,

				new nilnul.num_.positive.str_.Enumerable(

					txt.Select(
						c => this.indexOf(c)
					).Reverse()
				)

			).toNum();



			
		}

		




		public string phrase(int n)
		{

			return string.Join("", 
				new nilnul.num_._bijectiveNum.Root(this.radical)._toDigits(n).Select( d=> digitOf(d ) ).Reverse()
			);


		}






	}
}
