using System.Numerics;

namespace nilnul._num.bigint
{
	public abstract class BeOfInA
		:
		nilnul._num.bigint.BeOfInI
	{
		public abstract bool be(in BigInteger val);
		public bool be(BigInteger val) {
			return be(in val);
		}

	}
}
