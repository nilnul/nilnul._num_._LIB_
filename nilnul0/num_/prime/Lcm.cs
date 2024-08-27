using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.num.natural._test.prime
{
	[TestClass]
	public class LCM
	{
		[TestMethod]
		public void Lcm_test()
		{
			var r = nilnul.num.natural.collection.op.Lcm.Eval(1, 2, 3);

			Debug.Assert(r == 6);


			Debug.Assert(num.natural.collection.op.Lcm.Eval(1,2,3,4,5,6,7,8)==840);


		}


	}
}
