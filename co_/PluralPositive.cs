using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num_;

namespace nilnul.num.duo_
{
	public class PluralPositive : Tuple<nilnul.num_.Plural, nilnul.num_.Positive>
	{
		public PluralPositive(Plural item1, Positive item2) : base(item1, item2)
		{
		}
	}
}
