using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.phrase_
{
	/// <summary>
	/// prefixxing nils are insignificant, and thus removed.
	/// </summary>
	static public class _DecX
	{
		/// <summary>
		/// zero is a str of zeros so may be empty
		/// </summary>
		/// <param name="num"></param>
		/// <returns></returns>
		static public string Phrase(nilnul.Num num) {
			return num.ToString().TrimStart('0');
			//return nilnul.num_.radix_.Dec.Create(num).ToString();
		}

		static public string _Phrase_assumeNum(BigInteger num) {
			return num.ToString().TrimStart('0');
		}

		[Obsolete(nameof(_Phrase_assumeNum) + " is preferred, as we will not do herer what integer project shall do.")] 
		static public string Phrase(BigInteger num) {
			return _Phrase_assumeNum(num);
		}

		static public string Phrase(NumI1 num) {
			var r= num.ToString();
			return r.TrimStart('0');
		}
		static public string Phrase(NumI num) {
			var r= num.ToString();
			return r.TrimStart('0');
		}

		static public string Phrase(Num1 num) {
			var r= num.ToString();
			return r.TrimStart('0');
		}


		static public string _Phrase_assumeNum(int num) {
			return num.ToString().TrimStart('0');
		}

		[Obsolete(nameof(_Phrase_assumeNum) + " is preferred, as we will not do herer what integer project shall do.")]

		static public string Phrase(int num) {
			return _Phrase_assumeNum(num);
			//return nilnul.num_.radix_.Dec.Create(num).ToString();
		}



	}
}
