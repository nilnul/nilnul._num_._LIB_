using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.num.natural._test
{
	[TestClass]
	public class DoubleFactorClass
	{
		[TestMethod]
		public void DoubleFactor()
		{
			var r = nilnul.num.natural.func.DoubleFactorialX._Eval(10);;
			var factor = nilnul.num.natural.Factoring._Eval_recur(r);
		}


	}
}
