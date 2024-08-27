using nilnul.num_.plural.be_.prime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.plural_
{
	public interface IPrime { }

	/// <summary>
	/// avoid a second check against the number stored in db
	/// </summary>
	public interface PrimeI

	{
		plural.be_.prime.En plural {get;}
	}
	public class Prime
		:
		plural.be_.prime.En
		,
		PrimeI
	{
		public Prime(Plural1 val) : base(val)
		{
		}

		public Prime(int key):this(new Plural1(key))
		{
		}

		public Prime(BigInteger key):this(new Plural1(key))
		{
		}


		public En plural => this;
	}
}
