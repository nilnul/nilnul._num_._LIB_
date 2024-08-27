using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.num.natural._test.prime
{
	[TestClass]
	public class Prime
	{
		[TestMethod]
		public void isPrime()
		{

			var r = nilnul.num.natural.prime.collection.AutoGrowDb.Contains(2);

			Debug.Assert(r);

			r = nilnul.num.natural.prime.collection.AutoGrowDb.Contains(3);

			Debug.Assert(r);

			r= nilnul.num.natural.prime.collection.AutoGrowDb.Contains(4);

			Debug.Assert(!r);

			r= nilnul.num.natural.prime.collection.AutoGrowDb.Contains(101);

			Debug.Assert(r);



	


		}


	}
}
