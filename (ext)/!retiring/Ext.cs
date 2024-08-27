using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N = nilnul.num.bigint.be.Natural.Asserted;

namespace nilnul.num
{
	[Obsolete()]
	public abstract class ExtA
		:ExtI
	{

		static public bool operator <(ExtA x, ExtA y) {
			return ext_.Comparer.Instance.Compare(x, y)<0;
		}
		static public bool operator >(ExtA x, ExtA y) {
			return y<x;
		}

		

		static public implicit operator ExtA(N x) {
			return new ext_.Seed(x);
		}



	}

	
}
