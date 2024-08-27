using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P = nilnul.num_.Plural1;

namespace nilnul.num_.plural.be
{
	public class Vow
		: nilnul.obj.be.Vow4<P>
		,plural.VowI
	{
		public Vow(BeI1<P> be) : base(be)
		{
		}

		public Vow(Predicate<P> predicate) : base(predicate)
		{
		}

		public Vow(Func<P, bool> func) : base(func)
		{
		}
	}
}
