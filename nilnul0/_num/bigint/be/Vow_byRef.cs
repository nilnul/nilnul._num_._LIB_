using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._num.bigint.be
{
	public class Vow_byRef :
		nilnul.obj.be.VowOfRef<BigInteger>
		,
		nilnul._num.bigint.VowOfRefI

	//where TBe:nilnul._num.bigint.BeOfRefI,new()
	{
		public Vow_byRef(ref BeOfRefI<BigInteger> val) : base(ref val)
		{
		}

		public Vow_byRef(BeOfRefI<BigInteger> x) : base(x)
		{
		}
	}
}
