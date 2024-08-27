using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.natural._test.encoding
{
		[TestClass]

	public class FixedLength
	{
			[TestMethod]
			public void FixedLength_encoding()
			{
				var s = nilnul.num.natural.encoding.FixedLen.Encode(11, 16);
				
			}

	}
}
