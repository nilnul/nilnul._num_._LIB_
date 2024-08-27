using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.ord.co_.colRow_;

namespace nilnul.num.ord_.oneBased
{
	
	static public class _BoundX
	{
		static public nilnul.num.ord.Bound1<nilnul.num.ord_.OneBased> CreateGeneric(nilnul.num.ord_.OneBased lower, OneBased upper) {
			return new ord.Bound1<OneBased>(lower, upper); ;
		}
		static public nilnul.num.ord.Bound1<nilnul.num.ord_.OneBased> CreateGeneric(BigInteger lower, BigInteger upper) {
			return CreateGeneric(new OneBased(lower), new OneBased(upper)); 
		}
		static public nilnul.num.ord.Bound1 CreateGeneral(nilnul.num.ord_.OneBased lower, OneBased upper) {
			return new ord.Bound1(lower, upper); ;
		}

		static public nilnul.num.ord.Bound1 CreateGeneral(BigInteger lower, BigInteger upper) {
			return CreateGeneral(new OneBased(lower), new OneBased(upper)); ;
		}


	}
}
