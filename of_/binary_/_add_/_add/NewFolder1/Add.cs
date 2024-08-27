using System;
using System.Net;
using System.Numerics;

using N = nilnul.num._num.bigint.be.Natural.Asserted;

namespace nilnul.num.duo.op
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// 140614
	/// </remarks>
	public partial class Add
		:
		Op
	{
		static public N Eval(N augend, N addend) {

			return new N(augend.val + addend.val);
		
		}
		static public N Eval_retN(BigInteger augend, BigInteger addend) {

			return new N(augend + addend);
		
		}

		public Add()
			:base(Eval)
		{

		}

		static public Add Instance = SingletonByDefaultNew<Add>.Instance;

		//static public ExprI Call(ExprI a,ExprI b) {

		//	return new binary.Expr(Instance, a, b);

		//}

		static public class Pow
		{
			static public BigInteger Eval(BigInteger _n, BigInteger index) {

				BigInteger r = 0;
				while (index-->0)
				{
					r += _n;
				}
				return r;
			}
		}
	

	

		
	}
}
