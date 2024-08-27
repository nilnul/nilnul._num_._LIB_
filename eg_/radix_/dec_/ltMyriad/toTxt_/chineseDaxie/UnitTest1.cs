using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.num._test.eg_.radix_.dec_.ltMyriad.toTxt_.chineseDaxie
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void ltMyriad2ChineseDaxie()
		{

			test(0, "零");
			test(1, "壹");
			test(9, "玖");
			test(10, "壹拾");
			test(11, "壹拾壹");
			test(19, "壹拾玖");
			test(20, "贰拾");
			test(21, "贰拾壹");
			test(99, "玖拾玖");
			test(100, "壹佰");
			test(101, "壹佰零壹");
			test(110, "壹佰壹拾");
			test(111, "壹佰壹拾壹");
			test(199, "壹佰玖拾玖");
			test(200, "贰佰");
			test(201, "贰佰零壹");
			test(1000, "壹仟");
			test(1001, "壹仟零壹");
			test(1010, "壹仟零壹拾");
			test(1011, "壹仟零壹拾壹");
			test(1100, "壹仟壹佰");
			test(1101, "壹仟壹佰零壹");
			test(1110, "壹仟壹佰壹拾");
			test(1200, "壹仟贰佰");
			test(9000, "玖仟");
			test(9009, "玖仟零玖");

			test(9110, "玖仟壹佰壹拾");
			test(9900, "玖仟玖佰");
			test(9990, "玖仟玖佰玖拾");
			test(9999, "玖仟玖佰玖拾玖");




		}

		private void test(int i ,string t) {

			Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(t,
				nilnul.num_.radix_.dec_.ltMyriad.toTxt_.ChineseDaxie.Singleton._toTxt(i)
				
				
			);

		}


	}
}
