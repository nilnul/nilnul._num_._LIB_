using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul._num.bigint.be_
{
	//extern alias obj;

	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// <c> monad, dyad,triad, hexad, octad  nonad, </c>
	/// </remarks>
	public class Polyadic
		:
		//obj::
		nilnul.obj.be_.FroFunc<BigInteger>
		,
		BeI
				,
		_num.bigint.BeOfRefI
	{
		static public bool Eval(BigInteger x)
		{
			return x > 2;
		}

		public bool be(ref BigInteger x)
		{
			return x > 2;
			//throw new NotImplementedException();
		}

		public Polyadic()
			: base(Eval)
		{

		}


	}
}

