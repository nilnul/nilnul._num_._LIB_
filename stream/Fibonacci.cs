using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Assert1 = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace nilnul.num._test.stream
{
	[TestClass]
	public class FibonacciTest
	{
		[TestMethod]
		public void Fibonacci_item_byRecurWithFold()
		{
			var list = new List<int>();
			for (int i = 0; i < 10; i++)
			{
				list.Add(
					natural.sequence.Fibonacci.Item_tailRecurByFold(i)
					);

			}


		}
		[TestMethod]
		public void Fibonacci_Item()
		{
			uint result = 13;

			var item = nilnul.num.natural.sequence.Fibonacci.Item2(7);

			Assert1.AreEqual(item, (ulong)13);
		}
		[TestMethod]
		public void Fibonacci_Item_matrixPow()
		{
			Assert1.AreEqual(num.stream.Fibonacci.Item_byMatrixPow(0), (ulong)0);
			Assert1.AreEqual(num.stream.Fibonacci.Item_byMatrixPow(1), (ulong)1);
			Assert1.AreEqual(num.stream.Fibonacci.Item_byMatrixPow(2), (ulong)1);
			Assert1.AreEqual(num.stream.Fibonacci.Item_byMatrixPow(3), (ulong)2);
			Assert1.AreEqual(num.stream.Fibonacci.Item_byMatrixPow(4), (ulong)3);
			Assert1.AreEqual(num.stream.Fibonacci.Item_byMatrixPow(5), (ulong)5);
			Assert1.AreEqual(num.stream.Fibonacci.Item_byMatrixPow(6), (ulong)8);
			Assert1.AreEqual(num.stream.Fibonacci.Item_byMatrixPow(7), (ulong)13);
			Assert1.AreEqual(num.stream.Fibonacci.Item_byMatrixPow(8), (ulong)21);




		}
	}
}
