using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N = nilnul.Num;//.bigint.be.Natural.Asserted;

namespace nilnul.num
{

	public abstract class ExtA1
		: ExtI
	{

		static public bool operator <(ExtA1 x, ExtA1 y)
		{
			return ext_.Comparer1.Instance.Compare(x, y) < 0;
		}
		static public bool operator >(ExtA1 x, ExtA1 y)
		{
			return y < x;
		}

		static public bool operator >=(ExtA1 x, ExtA1 y)
		{
			return ext_.comparer.Decider.Singleton.inc(x, y);
		}
		static public bool operator <=(ExtA1 x, ExtA1 y)
		{
			return ext_.comparer.Decider.Singleton.inside(x, y);
		}

		static public bool operator ==(ExtA1 x, ExtA1 y)
		{
			return ext_.comparer.Decider.Singleton.eq(x, y);
		}

		static public bool operator !=(ExtA1 x, ExtA1 y)
		{
			return !(x == y);
		}

		static public implicit operator ExtA1(N x)
		{
			return new ext_.Basic(x);
		}



	}


}
