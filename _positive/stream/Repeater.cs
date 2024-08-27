using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.natural.__bigint.be;
using System.Numerics;

namespace nilnul.num._positive.stream
{
	public partial class Repeater : StreamI
	{
		private num.natural.__bigint.be.Positive.Asserted _val;

		public num.natural.__bigint.be.Positive.Asserted val
		{
			get { return _val; }
			set { _val = value; }
		}

		public Repeater(num.natural.__bigint.be.Positive.Asserted num)
		{
			_val = num;
		}
		public Repeater(BigInteger num)
			:this(
				 new num.natural.__bigint.be.Positive.Asserted(num)
				 )
		{
			
		}
		public Positive.Asserted next()
		{
			return _val;
			throw new NotImplementedException();
		}

		public void reset()
		{
			return;
			throw new NotImplementedException();
		}
	}
}
