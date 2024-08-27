using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

using N = nilnul._num.bigint.be.Natural.Asserted;
using System.Numerics;
using System.Linq;

namespace nilnul.num._test.stream.alterPermuate
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void EulerUpDown()
		{
			Debug.WriteLine(
				nilnul.str.to.txt.X.ToTxt(
					new nilnul.slider.to_.Enumerable<BigInteger>(
						new nilnul.num.slider_.EulerUpDown()
					).Take(10)
				)
			);
		}
	}
}
