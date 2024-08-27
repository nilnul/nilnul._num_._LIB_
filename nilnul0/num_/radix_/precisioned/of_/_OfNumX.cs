using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;
using nilnul.num.str_;
using nilnul.num.to_;

namespace nilnul.num_.radix_.precisioned.of_
{
	/// <summary>
	/// express 0123000 as 0123000*10^0, where 0123000 is the precision;
	/// 
	/// </summary>
	static public class _OfNumX 
	{





		static public Precisioned Of(nilnul.Num_ofIn num, nilnul.num_.ref_.vowless_.Plural radic)
		{
			return new Precisioned(
				new _radix.Radic(radic)._toPositions_0nonneg(num.eeByRef)
				,
				radic
			);
		}

		static public Precisioned Of(BigInteger _num8nonneg, BigInteger _radic8plural)
		{
			return new Precisioned(
				new _radix.Radic(_radic8plural)._toPositions_0nonneg(_num8nonneg)
				,
				_radic8plural
			);
		}



	}
}
