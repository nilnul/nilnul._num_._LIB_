using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix.phrase_
{
	/// <summary>
	/// empty str for 0;
	/// </summary>
	static public class _EmptibleX
	{
		static public string _Phrase_1valid(num_.RadixI radix, char[] alphabet)
		{

			var t =  string.Join(
				"",
				radix.gits.Select(x => alphabet[(int)(x.eeByRef)])
			);

			return t;
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

		static public string _Phrase_1valid(num_.Radix2 radix, char[] alphabet)
		{


			return string.Join(
				"",
				radix.digits.Select(x => alphabet[(int)(x.en)])
			);
		}



		static public string Phrase(num_.RadixI radix)
		{
			var radic = (int)radix.radic.eeByRef;

			var alphabet = nilnul.character.sortie_.alphabet_.radix_.Hex.Chars.Take(
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

			var alphabet = nilnul.character.sortie_.alphabet_.radix_.Hex.Chars.Take(
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
			var radic = (int)radix.root.ed.val;

			var alphabet = nilnul.character.sortie_.alphabet_.radix_.Hex.Chars.Take(
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
