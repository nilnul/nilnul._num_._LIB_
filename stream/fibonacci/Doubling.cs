using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Assert1 = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using System.Numerics;

namespace nilnul.num._test.stream.fibonacci
{
	[TestClass]
	public class Doubling_testClass
	{

		[TestMethod]
		public void Fibonacci_Doubling_item()
		{
			_testFunc(0, 0);
			_testFunc(1, 1);
			_testFunc(2, 1);
			_testFunc(3, 2);
			_testFunc(4, 3);
			_testFunc(5, 5);
			_testFunc(6, 8);
			_testFunc(7, 13);
			_testFunc(8, 21);



		}

		private void _testFunc(BigInteger index, BigInteger image)
		{

			Assert1.AreEqual(num.stream.fibonacci.Doubling.Item(index), image);


		}
	}
}
