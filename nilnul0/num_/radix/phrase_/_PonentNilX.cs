using nilnul.character.border.duo.be;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix.phrase_
{
	/// <summary>
	/// as <see cref="radix._PhraseX"/> doesnot expose radic information, we here use a form such as: 01230*16^0 to expose information. Do note here that the radic,16, uses a defaulted base from the runtime, while the precision uses its own radic;
	/// </summary>
	/// <remarks>
	/// this is in fact to convert into <see cref="radix_.Precisioned"/> with 0 as ponent;
	/// </remarks>
	static public class _PonentNilX
	{
		static public string _Phrase_0precision_1radic(string precision,BigInteger radic ) {
			return $"{ precision}*{radic}^0";

		}
		

		public static string _Phrase_1valid(IEnumerable<Num_ofIn> gits, char[] alphabet)
		{
			return _Phrase_0precision_1radic(
				num_.radix._PhraseX._Phrase_1valid(gits,alphabet)
				,
				alphabet.Length
			)		;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="radix"></param>
		/// <param name="alphabet"></param>
		/// <returns></returns>
		static public string _Phrase_1valid(num_.RadixI radix, char[] alphabet)
		{
			

			return Phrase_0precision_1radic(
				num_.radix._PhraseX._Phrase_1valid(radix,alphabet)
				,
				radix.radic
			)		;
			

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

	


		static public string Phrase_0precision_1radic(string precision,num_.ref_.vowless_.Plural radic ) {
			return _Phrase_0precision_1radic(precision,radic.eeByRef);

		}
		public static string Phrase(IEnumerable<Num_ofIn> gits, ref_.vowless_.Plural radic)
		{
			return Phrase_0precision_1radic(
				num_.radix._PhraseX.Phrase(gits,radic)
				,
				radic
			)	;
		}

		static public string Phrase(num_.RadixI radix)
		{
			return _Phrase_0precision_1radic(
				num_.radix._PhraseX.Phrase(radix)
				
				,
				radix.radic
			);
			
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
