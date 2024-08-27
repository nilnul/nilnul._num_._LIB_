using nilnul.num.natural;
using nilnul.num.natural.prime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Plural = nilnul.num.bigint.be.Plural.Asserted;

namespace nilnul.num.plural.be
{

	extern alias bit;
	/// <summary>
	/// this stands a prime number.
	/// </summary>
	/// 
	public partial class Prime
		:bit:: nilnul.obj.BeI< num.bigint.be.Plural.Asserted>
	{

		public bool be(num.bigint.be.Plural.Asserted val)
		{
			return /*natural.prime.collection.AutoGrowMem*/nilnul.num_.plural_.prime.set_.db_.ef.AutoGrowMem._IsPrime(val.val);
			throw new NotImplementedException();
		}

		public class Asserted:nilnul.obj.Asserted1<num.bigint.be.Plural.Asserted,Prime>
		{
			public Asserted(num.bigint.be.Plural.Asserted v):base(v)
			{
			}

			public Asserted(BigInteger v):this(
				new Plural(v)	
			)
			{

			}

			public override string ToString()
			{
				return val.ToString();
			}



		}
	}
	
}
