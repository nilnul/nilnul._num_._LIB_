using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.co.be
{
	public class Vow : nilnul.obj.be.Vow4<
		nilnul.num.Co_onInteface
	//nilnul.num.co.Be_ofCoOnInterfaceI
	>
		,
		num.co.VowI
	{
		public Vow(BeI1<Co_onInteface> be) : base(be)
		{
		}

		public Vow(Predicate<Co_onInteface> predicate) : base(predicate)
		{
		}

		public Vow(Func<Co_onInteface, bool> func) : base(func)
		{
		}
	}
}
