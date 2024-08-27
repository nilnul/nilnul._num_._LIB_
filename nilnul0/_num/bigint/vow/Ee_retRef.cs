using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._num.bigint.vow
{
	public class Ee_retRef<TVow> :
		nilnul.obj.vow.Ee_byRef<BigInteger, TVow>
		where TVow
		:
		nilnul.obj.Vow_ofRefI<BigInteger>
	{
		public Ee_retRef( ref BigInteger val, TVow vow) : base(ref val, vow)
		{
		}
	}
	public class Ee_retRef : Ee_retRef<
		nilnul.obj.Vow_ofRefI<BigInteger>
	>

	{
		

		public Ee_retRef(ref BigInteger val, Vow_ofRefI<BigInteger> vow) : base(ref val, vow)
		{
		}
	}


}
