using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace nilnul.num.natural._test.op
{
	[TestClass]
	public class Sqrt
	{
		[TestMethod]
		public void Sqrt_Eval() {
			var x = nilnul.num.natural.op.unary.SqrtFloorX.SqrtFloor(3);
			Debug.Assert(x == 1);

			Debug.Assert(
				num.natural.op.unary.SqrtFloorX.SqrtFloor(100)==10	
			);

		}
	}
}
