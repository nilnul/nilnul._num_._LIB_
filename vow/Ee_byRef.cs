using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.vow
{


	public class Ee_byRef : nilnul.obj.vow.Ee1<nilnul.Num_byRef>

	{
		public ref BigInteger integer{ get {
				return ref base.ee.eeByRef;
			} }
		public Ee_byRef(Num_byRef val, VowI2<Num_byRef> vow) : base(val, vow)
		{
		}
	}

}
