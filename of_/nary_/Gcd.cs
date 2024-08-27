using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;

using N = nilnul._num.bigint.be.Natural.Asserted;


namespace nilnul.num.no.op_
{
	/// <summary>
	/// this is useful to define Gcd for a str.
	/// </summary>
	public class Gcd : OpI
	{
		public Natural.Asserted eval()
		{
			return (N)0;
			throw new NotImplementedException();
		}

		static public readonly Gcd Singleton = SingletonByDefault<Gcd>.Instance;

	}
}
