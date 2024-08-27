using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix_.myriad.toTxt_
{
	public class ChineseDaxie
	{
		public char zeroChar = nilnul.num_.radix_.dec_.ltMyriad.toTxt_.ChineseDaxie.Singleton.decDigits[0];



		public string units = "個萬亿兆";


		public string _toTxt(int i)
		{
			return _toTxt_trimmedInsignificants((nilnul.num_.radix_.Myriad)i);
		}

		/// <summary>
		/// trim the starting zero.
		/// </summary>
		/// <param name="_trimmedInsignificants"></param>
		/// <returns></returns>
		public string _toTxt_trimmedInsignificants(nilnul.num_.radix_.Myriad _trimmedInsignificants)
		{

			var appendedZero = false;

			var zerosCount = _trimmedInsignificants.digits.TakeWhile(x => x == 0).Count();

			var skippedZeros = _trimmedInsignificants.digits.SkipWhile(x => x == 0);


			var r = new StringBuilder();

			for (int i = skippedZeros.Count() - 1; i >= 0; i--)
			{

				if (skippedZeros.ElementAt(i) == 0)
				{
					if (appendedZero)
					{

					}
					else
					{
						r.Append(zeroChar);
						appendedZero = true;
					}

				}
				else
				{
					var ltMyriad = (int)skippedZeros.ElementAt(i);
					if (ltMyriad < 1000)
					{
						if (!appendedZero)
						{
							r.Append(zeroChar);

						}

					}

					r.Append(
						$@"{
							nilnul.num_.radix_.dec_.ltMyriad.toTxt_.ChineseDaxie.Singleton._toTxt(
								(int)skippedZeros.ElementAt(i)
							)
						}{
							units[i + zerosCount]
						}"
					);
					appendedZero = false;
				}
			}

			var trimmed = r.ToString().TrimEnd(units.First()).TrimStart(zeroChar);

			if (trimmed == "")
			{
				return $"{zeroChar}";

			}
			return trimmed;

		}


		static public readonly ChineseDaxie Singleton = nilnul.obj.SingletonByDefault<ChineseDaxie>.Instance;


	}
}
