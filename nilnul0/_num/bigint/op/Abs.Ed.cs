using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._num.bigint.op
{
	public partial class Abs
    {

		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// maybe this is not a good candidate for the definition of natural numb, for Abs is only defined after integer
		/// </remarks>
		/// <see cref=""/>
		/// <seealso cref=""/>
		/// 
		[Obsolete()]
		public class Ed
		{
			private BigInteger _val;

			public BigInteger val
			{
				get { return _val; }
				private set { _val = value; }
			}

			public Ed(BigInteger val)
			{
				_val = BigInteger.Abs(val);
			}

			public Ed(uint uinteger)
			{
				_val = uinteger;
			}


			static public implicit operator BigInteger(Ed ed)
			{
				return ed._val;
			}
			static public implicit operator Ed(uint uinteger)
			{
				return new Ed(uinteger);
			}


			static public Ed operator *(Ed a, Ed b)
			{
				return new Ed(a.val * b.val);
			}



		}

	}
}
