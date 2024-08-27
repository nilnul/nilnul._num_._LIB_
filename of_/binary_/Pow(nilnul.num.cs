using nilnul.num.natural;
using nilnul.num.natural.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using N = nilnul.num.natural.Natural_bigInteger;

namespace nilnul.num.op_.binary_
{
	/// <summary>
	/// eg:2^3, which evaluates to 8;
	/// </summary>
	/// <remarks>
	/// as in 2^3, where 2 is the basic|radic (radic is used in <see cref="nilnul.num_.IRadix"/>), 3 is the ponent|indicand;
	/// later in nilnul.num.real, if indicand is num, it's called ponent, if indicand is integer, it's called indicand, if indicand is real, it's called pow;
	/// 
	/// </remarks>
	/// alias:
	///		pon
	///			where 'n' means natural
	///	vs:
	///		pol|indic
	///			where 'l' means line, an integer
	///		pow
	///			where w means widened, a real;
	public  class Pow
		:BinaryI1
	{


		static public Pow Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Pow>.Instance;
			}
		}

		public Num1 op(Num1 par, Num1 par1)
		{
			return new Num1(  _PowX._Op(par,par1));
		}

		public Num1 op(BigInteger a, BigInteger b) {
			return op(
				new Num1(a)
				,
				new Num1(b)
			);
		}
		public Num1 op(Num1 a, BigInteger b) {
			return op(
				a
				,
				new Num1(b)
			);
		}

	}

}
