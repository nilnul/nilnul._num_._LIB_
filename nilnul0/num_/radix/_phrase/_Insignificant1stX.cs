using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix._phrase
{
	/// <summary>
	/// most significant bit last;
	/// </summary>
	static public class _Insignificant1stX
	{
		static public IEnumerable<char> _PhraseAsChars_1valid(IEnumerable<int> _gits, char[] _alfabet)
		{
			return _gits.Select(
				x => _alfabet[x]
			);
		}
		static public IEnumerable<char> _PhraseAsChars_1valid(IEnumerable<BigInteger> _gits, char[] _alfabet)
		{

			return _PhraseAsChars_1valid(_gits.Select(x=>(int)x), _alfabet);
		}

		static public IEnumerable<char> _PhraseAsChars_1valid(IEnumerable<Num_ofIn> _gits, char[] _alfabet)
		{

			return _PhraseAsChars_1valid(_gits.Select(x=>x.eeByRef), _alfabet);
		}

		static public IEnumerable<char> _PhraseAsChars_1valid(num_.RadixI radix, char[] alphabet)
		{
			return  _PhraseAsChars_1valid(radix.gits,alphabet);
		}
		static public string _Phrase_1valid(num_.RadixI radix, char[] alphabet)
		{
			return  string.Join(
				""
				,
				_PhraseAsChars_1valid(radix,alphabet)
			);
		}


		static public string _Phrase_1valid(num_.Radix radix, char[] alphabet)
		{

			var t =  string.Join(
				"",
				radix.digits.Select(x => alphabet[(int)(x.val)])
			);

			return t;
		}

		static public string _Phrase_1valid(num_.Radix1 radix, char[] alphabet)
		{

			var t =  string.Join(
				"",
				radix.digits.Select(x => alphabet[(int)(x.en)])
			);

			return t;
		}
		static public IEnumerable<char> _AsChars_1valid(num_.Radix2 radix)
		{
			var radic = (int)radix.radic.eeByRef;

			var alphabet = nilnul.character.sortie_.alphabet_.radix_.Hex.Chars.Take(
				radic
			).ToArray();
			return 	_AsChars_1valid(radix, alphabet)	;

		}

		static public IEnumerable<char> _AsChars_1valid(num_.Radix2 radix,char[] _chars)
		{

			return 	radix.digits.Select(x => _chars[(int)(x.en)])	;

		}


		static public string _Phrase_1valid(num_.Radix2 radix, char[] alphabet)
		{


			return string.Join(
				"",
				radix.digits.Select(x => alphabet[(int)(x.en)])
			);
		}



		static public string Phrase(num_.RadixI radix)
		{
			

			return _Phrase_1valid(
				radix
				,
				Alfabet(radix.radic)
			);

		}
		static public string Phrase(num_.Radix2 radix)
		{
			

			return _Phrase_1valid(
				radix
				,
				Alfabet(radix.radic)
			);

		}
		static public string Phrase(num_.Radix1 radix)
		{
			

			return _Phrase_1valid(
				radix
				,
				_Alfabet_0plural(radix.root.ed.val)
			);
		}

		public static char[] _Alfabet_0plural(int radic)
		{
			var alphabet = nilnul.character_.cha.sortie_.alfabet_.Digit9latin.Generated.Take(
				radic
			).ToArray();

			if (alphabet.Length < radic)
			{
				throw new Exception($"We have default alphabet for {alphabet.Length} only; {radic} is beyond that limit.");
			}
			return alphabet;

		}

		public static char[] _Alfabet_0plural(BigInteger radic)
		{
			
			return _Alfabet_0plural((int)radic);

		}

		static public char[] Alfabet(ref_.vowless_.Plural radic) {
			var radic8int = (int)radic.eeByRef;
			
			return _Alfabet_0plural(radic8int);

		}

		public static IEnumerable<char> PhraseAsChars(IEnumerable<Num_ofIn> gits, ref_.vowless_.Plural radic)
		{
			

			return _PhraseAsChars_1valid(gits, Alfabet(radic));
		}
	}

}
