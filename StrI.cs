using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using N = nilnul.num._num.bigint.be.Natural.Asserted;

namespace nilnul.num
{
	public abstract class StrA :  type.StrA<N> , StrI1{



	}

	public interface StrI1 :num.type.StrI2<N>
	{

	}



	public interface StrI :IEnumerable<BigInteger>
	{

	}


}
