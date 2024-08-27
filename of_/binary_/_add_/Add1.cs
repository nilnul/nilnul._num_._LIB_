using System;
using System.Net;
using System.Numerics;

using N = nilnul.num.natural.Natural_bigInteger;

namespace nilnul.num.natural.op
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// 140614
	/// </remarks>
	public partial class Add1
		:
		Binary
		,
		BinaryI
	{
		static public N Eval(Natural_bigInteger augend, Natural_bigInteger addend) {

			return new Natural_bigInteger(augend.val + addend.val);
		
		}

		public Add1()
			:base(Eval)
		{

		}

		static public Add1 Instance = SingletonByDefaultNew<Add1>.Instance;

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
