using System;
using System.Net;
using System.Numerics;

using N = nilnul.NumI;

namespace nilnul.num.combine_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// 140614
	/// </remarks>
	public partial class Add
		:
		CombineI1

	{
		public N combine(N arg, N arg1)
		{
			return new nilnul.Num(arg.toBigint()+arg1.toBigint());
			throw new NotImplementedException();
		}


		static public readonly Add Singleton = nilnul.obj.SingletonByDefault<Add>.Instance;

	}
}
