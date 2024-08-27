using System;
using System.Net;
using System.Numerics;

using N = nilnul.Num1;

namespace nilnul.num.op_.binary_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// 140614
	/// </remarks>
	public  class Add
		:
		nilnul.num.op_.BinaryI1
		,
		nilnul.num.op_.BinaryI_onInteger
		,
		nilnul.num.op_.BinaryI_onInterfaces

	{
		public N op(N arg, N arg1)
		{
			return new N(arg.en+arg1.en);
		}

		public BigInteger op(BigInteger par, BigInteger par1)
		{
			return par + par1;
			//throw new NotImplementedException();
		}

		public NumI1 op(NumI1 par, NumI1 par1)
		{
			return new Num1(op(par.toBigint(),par1.toBigint()));

		}

		static public Add Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Add>.Instance;
			}
		}

	}
}
