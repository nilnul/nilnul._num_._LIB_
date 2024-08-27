using nilnul.character.border.duo.be;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix
{
	/// <summary>
	/// most significant bit first;
	/// </summary>
	static public class _PhraseX
	{
		static public string Noempty(string s) {
			return s == string.Empty ? "0" : s;
		}
		public static string Noempty(IEnumerable<char> enumerable)
		{
			return Noempty(
				nilnul.txt.of_._CharsX.ConcatAsTxt( enumerable)
			);
		}

		public static IEnumerable<char> _AsChars_1valid(IEnumerable<Num_ofIn> gits, char[] alphabet)
		{
			return _phrase._Insignificant1stX._PhraseAsChars_1valid(gits,alphabet).Reverse()
			;
		}
		public static string _Phrase_1valid(IEnumerable<Num_ofIn> gits, char[] alphabet)
		{
			return Noempty(
				_AsChars_1valid(gits,alphabet)
			);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="radix"></param>
		/// <param name="alphabet"></param>
		/// <returns></returns>
		static public string _Phrase_1valid(num_.RadixI radix, char[] alphabet)
		{
			

			return Noempty(
_phrase._Insignificant1stX._Phrase_1valid(radix,alphabet).Reverse()
			);
			

		}


		static public string _Phrase_1valid(num_.Radix radix, char[] alphabet)
		{
			
			return _Phrase_1valid((num_.RadixI) radix,alphabet);
		}
		static public string _Phrase_1valid(num_.Radix1 radix, char[] alphabet)
		{
			return _Phrase_1valid((num_.RadixI) radix,alphabet);
		}

		static public string _Phrase_1valid(num_.Radix2 radix, char[] alphabet)
		{
			return _Phrase_1valid((num_.RadixI) radix,alphabet);
			
		}

		public static IEnumerable<char> AsChars(IEnumerable<Num_ofIn> gits, ref_.vowless_.Plural radic)
		{
			return 		_phrase._Insignificant1stX.PhraseAsChars(gits, radic).Reverse();
		}

		public static string Phrase(IEnumerable<Num_ofIn> gits, ref_.vowless_.Plural radic)
		{
			return Noempty(
				AsChars(gits,radic)
			);
		}

		static public string Phrase(num_.RadixI radix)
		{
			return Phrase(radix.gits,radix.radic);
			
		}
		static public string Phrase(num_.Radix radix)
		{
			

			return Phrase(
				(RadixI)radix
			);
		}
		static public string Phrase(num_.Radix1 radix)
		{
			return Phrase(
				(RadixI)radix
			);

		}
		static public string Phrase(num_.Radix2 radix)
		{
			return Phrase(
				(RadixI)radix
			);
			
		}

	}

}
