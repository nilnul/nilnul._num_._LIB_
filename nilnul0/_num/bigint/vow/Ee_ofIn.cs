using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._num.bigint.vow
{
	public class Ee_ofIn<TVow> :
		nilnul.obj.vow.Ee_ofIn<BigInteger, TVow>
		where TVow
		:
		nilnul.obj.VowI_ofIn<BigInteger>
	{
		public Ee_ofIn( in BigInteger val, TVow vow) : base(in val, vow)
		{
		}
	}

	public class Ee_ofIn : Ee_ofIn<
		nilnul.obj.VowI_ofIn<BigInteger>
	>

	{
		

		public Ee_ofIn(in BigInteger val, VowI_ofIn<BigInteger> vow)
			:
			base(in val, vow)
		{
		}
	}


}
