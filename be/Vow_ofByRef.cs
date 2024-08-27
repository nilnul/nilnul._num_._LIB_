using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.be
{
	

	public class Vow_ofByRef : nilnul.obj.be.Vow4<nilnul.Num_byRef>
		,
		nilnul.num.VowOfByRefI

	{
		
		public Vow_ofByRef(BeI1<Num_byRef> be) : base(be)
		{
		}

		public Vow_ofByRef(Predicate<Num_byRef> predicate) : base(predicate)
		{
		}

		public Vow_ofByRef(Func<Num_byRef, bool> func) : base(func)
		{
		}

		
	}

}
