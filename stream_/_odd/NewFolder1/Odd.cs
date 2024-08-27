using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num._num.bigint.be;

namespace nilnul.num.stream.eg
{
	[Obsolete()]
	public  class Odd:StreamA
	{
		static public BigInteger GetItem(BigInteger x) {
			return 2 * x + 1;

		}
		static public BigInteger GetItem(int x) {
			return 2 * x + 1;

		}

		private BigInteger _b4head;

		public BigInteger b4head
		{
			get { return _b4head; }
			set { _b4head = value; }
		}

		public Odd()
		{
			reset();

		}
		public override _num.bigint.be.Natural.Asserted next()
		{
			return new _num.bigint.be.Natural.Asserted(_b4head+=2);

			throw new NotImplementedException();
		}



		public override void reset()
		{
			_b4head = -1;
			return;
			throw new NotImplementedException();
		}
	}
}
