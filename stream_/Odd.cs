using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num._num.bigint.be;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num.stream_
{
	public  class Odd:StreamA2,StreamI3
	{
		static public BigInteger GetItem(BigInteger x) {
			return 2 * x + 1;

		}
		static public BigInteger GetItem(int x) {
			return 2 * x + 1;

		}

		private BigInteger _b4head;// /*default */=0;

		public BigInteger b4head
		{
			get { return _b4head; }
			set { _b4head = value; }
		}

		public Odd()
		{
			reset();

		}
		public override N next()
		{
			return new N(_b4head+=2);

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
