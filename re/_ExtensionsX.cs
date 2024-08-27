using System.Numerics;

namespace nilnul.num.re
{
	static public class _ExtensionsX
	{
		static public bool Re(this num.ReI re, BigInteger x, BigInteger y) {
			return re.re(
				 nilnul.Num_ofIn.Of(
				x
				)
				,

				 nilnul.Num_ofIn.Of(
				y
				)
			);
		}

		static public bool Re(this num.ReI re, BigInteger x, nilnul.Num1 y) {
			return re.re(
				 nilnul.Num_ofIn.Of(
				x
				)
				,

				
				y
				
			);
		}

	}
}
