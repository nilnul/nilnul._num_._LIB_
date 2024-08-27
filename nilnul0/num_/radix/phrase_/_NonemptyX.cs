using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix.phrase_
{
	/// <summary>
	/// "0", not empty str, for 0;
	/// </summary>
	static public class _NonemptibleX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="radix"></param>
		/// <param name="alphabet"></param>
		/// <returns></returns>
		static public string _Phrase_1valid(num_.RadixI radix, char[] alphabet)
		{
			var t = _EmptibleX._Phrase_1valid(radix,alphabet);
			if (t==string.Empty)
			{
				return "0";
			}
			return t;

		}

		static public string _Phrase_1valid(num_.Radix radix, char[] alphabet)
		{
			var t = _EmptibleX._Phrase_1valid(radix,alphabet);
			if (t==string.Empty)
			{
				return "0";
			}
			return t;
		}
		static public string _Phrase_1valid(num_.Radix1 radix, char[] alphabet)
		{
			var t = _EmptibleX._Phrase_1valid(radix,alphabet);
			if (t==string.Empty)
			{
				return "0";
			}
			return t;
		}

		static public string _Phrase_1valid(num_.Radix2 radix, char[] alphabet)
		{
			var t = _EmptibleX._Phrase_1valid(radix,alphabet);
			if (t==string.Empty)
			{
				return "0";
			}
			return t;
		}


		static public string Phrase(num_.RadixI radix)
		{
			var radic = (int)radix.radic.eeByRef;

			var alphabet = nilnul.character.sortie_.radix_.hex_._UppercaseX.AS_TXT.Take(
				radic
			).ToArray();

			if (alphabet.Length < radic)
			{
				throw new Exception($"We have default alphabet for {alphabet.Length} only; {radic} is beyond that limit.");
			}

			return _Phrase_1valid(
				radix
				,
				alphabet
			);
		}
		static public string Phrase(num_.Radix radix)
		{
			var radic = (int)radix.root.vowed.val ;

			var alphabet = nilnul.character.sortie_.radix_.hex_._UppercaseX.AS_TXT.Take(
				radic
			).ToArray();

			if (alphabet.Length < radic)
			{
				throw new Exception($"We have default alphabet for {alphabet.Length} only; {radic} is beyond that limit.");
			}

			return _Phrase_1valid(
				radix
				,
				alphabet
			);
		}
		static public string Phrase(num_.Radix1 radix)
		{
			var radic = (int)radix.root.vowed.val ;

			var alphabet = nilnul.character.sortie_.radix_.hex_._UppercaseX.AS_TXT.Take(
				radic
			).ToArray();

			if (alphabet.Length < radic)
			{
				throw new Exception($"We have default alphabet for {alphabet.Length} only; {radic} is beyond that limit.");
			}

			return _Phrase_1valid(
				radix
				,
				alphabet
			);
		}
		static public string Phrase(num_.Radix2 radix)
		{
			var radic = (int)radix.radic.eeByRef;

			var alphabet = nilnul.character.sortie_.radix_.hex_._UppercaseX.AS_TXT.Take(
				radic
			).ToArray();

			if (alphabet.Length < radic)
			{
				throw new Exception($"We have default alphabet for {alphabet.Length} only; {radic} is beyond that limit.");
			}

			return _Phrase_1valid(
				radix
				,
				alphabet
			);
		}



	}

}
