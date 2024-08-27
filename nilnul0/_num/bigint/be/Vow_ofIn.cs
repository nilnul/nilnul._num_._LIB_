using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._num.bigint.be
{
	public class Vow_ofIn :
		nilnul.obj.be.Vow_ofIn<BigInteger>
		,
		nilnul._num.bigint.vow_.OfInI

	//where TBe:nilnul._num.bigint.BeOfRefI,new()
	{
		public Vow_ofIn(in obj.BeI_ofIn<BigInteger> val) : base(in val)
		{
		}

		public Vow_ofIn(obj.BeI_ofIn<BigInteger> x) : base(x)
		{
		}
	}
}
