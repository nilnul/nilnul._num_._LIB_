using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix_.dec_.ltMyriad.toTxt_
{
	public class ChineseDaxie
	{
		public string decDigits = "零壹贰叁肆伍陆柒捌玖";

		public string units = "個拾佰仟";
		public string _toTxt(int _ltMyriad)
		{
			return _toTxt_trimmedInsignificants((nilnul.num_.radix_.Dec)_ltMyriad);
		}

		public string _toTxt_trimmedInsignificants(nilnul.num_.radix_.Dec _ltMyriad_trimmedInsignificants)
		{

			var appendedZero = false;

			var zerosCount = _ltMyriad_trimmedInsignificants.digits.TakeWhile(x => x == 0).Count();

			var skippedZeros = _ltMyriad_trimmedInsignificants.digits.SkipWhile(x => x == 0);


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
						r.Append(decDigits[0]);
						appendedZero = true;
					}

				}
				else
				{
					r.Append(
						$"{ decDigits[ (int)skippedZeros.ElementAt(i)]}{ units[i + zerosCount]}"
					);
					appendedZero = false;
				}
			}

			var trimmed = r.ToString().Trim(units.First());

			if (trimmed == "")
			{
				return $"{decDigits[0]}";

			}
			return trimmed;

		}
		public string _toTxt(nilnul.num_.radix_.Dec _ltMyriad)
		{

			_ltMyriad.trimInsignificants();

			return _toTxt_trimmedInsignificants(_ltMyriad);




		}


		static public readonly ChineseDaxie Singleton = nilnul.obj.SingletonByDefault<ChineseDaxie>.Instance;



	}
}
