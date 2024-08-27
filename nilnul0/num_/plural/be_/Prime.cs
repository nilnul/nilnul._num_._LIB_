using nilnul.num.natural;
using nilnul.num.natural.prime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Plural = nilnul.num.bigint.be.Plural.Asserted;

namespace nilnul.num_.plural.be_
{

	extern alias bit;
	/// <summary>
	/// this stands a prime number.
	/// </summary>
	/// 
	public  class Prime
		:
		nilnul.obj_.singular.Heir<Prime>
		,
		plural.BeI
	{

		nilnul.num_.plural_.prime.sortie_.db_.ef_.Determiner d = new plural_.prime.sortie_.db_.ef_.Determiner();

		public bool be(num_.Plural1 val)
		{
			return d.Contains((long)val.en);
			//return /*natural.prime.collection.AutoGrowMem*/nilnul.num_.plural_.prime.set_.db_.ef.AutoGrowMem._IsPrime(val);
			////throw new NotImplementedException();
		}





	}
	
}
