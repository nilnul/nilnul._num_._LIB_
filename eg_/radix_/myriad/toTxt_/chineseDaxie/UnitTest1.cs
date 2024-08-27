using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.num._test.eg_.radix_.myriad.toTxt_.chineseDaxie
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Myriad2ChineseDaxie()
		{

			test(0, "零");
			test(1, "壹");
			test(2, "贰");
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
			test(3000, "叁仟");
			test(9000, "玖仟");
			test(9009, "玖仟零玖");

			test(9110, "玖仟壹佰壹拾");
			test(9900, "玖仟玖佰");
			test(9990, "玖仟玖佰玖拾");
			test(9999, "玖仟玖佰玖拾玖");

			test(10000, "壹萬");
			test(10001, "壹萬零壹");
			test(10010, "壹萬零壹拾");
			test(10011, "壹萬零壹拾壹");
			test(10100, "壹萬零壹佰");

			test(10101, "壹萬零壹佰零壹");

			test(10110, "壹萬零壹佰壹拾");
			test(10111, "壹萬零壹佰壹拾壹");
			test(11000, "壹萬壹仟");
			test(11001, "壹萬壹仟零壹");
			test(11010, "壹萬壹仟零壹拾");
			test(11011, "壹萬壹仟零壹拾壹");
			test(11110, "壹萬壹仟壹佰壹拾");
			test(11111, "壹萬壹仟壹佰壹拾壹");

			test(100000000, "壹亿");
			test(100000001, "壹亿零壹");
			test(100000010, "壹亿零壹拾");
			test(100000011, "壹亿零壹拾壹");
			test(100000020, "壹亿零贰拾");
			test(100000021, "壹亿零贰拾壹");
			test(100000100, "壹亿零壹佰");
			test(100000101, "壹亿零壹佰零壹");

			test(100001000, "壹亿零壹仟");
			test(100001001, "壹亿零壹仟零壹");
			test(101000101, "壹亿零壹佰萬零壹佰零壹");
			test(101001001, "壹亿零壹佰萬壹仟零壹");

			test(101001101, "壹亿零壹佰萬壹仟壹佰零壹");
			test(101001991, "壹亿零壹佰萬壹仟玖佰玖拾壹");

			test(111001001, "壹亿壹仟壹佰萬壹仟零壹");


			test(111110000, "壹亿壹仟壹佰壹拾壹萬");
			test(111110001, "壹亿壹仟壹佰壹拾壹萬零壹");
			test(999999999, "玖亿玖仟玖佰玖拾玖萬玖仟玖佰玖拾玖");

			test(1000000000, "壹拾亿");
			test(1000000001, "壹拾亿零壹");


		}

		private void test(int i ,string t) {

			Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(
				t,
				nilnul.num_.radix_.myriad.toTxt_.ChineseDaxie.Singleton._toTxt(i)
				
			);

		}


	}
}
