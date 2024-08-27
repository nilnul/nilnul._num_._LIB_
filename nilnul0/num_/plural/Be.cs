using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.plural
{
	public interface BeI: nilnul.obj.BeI1<nilnul.num_.Plural1>
	{
	}

	public class Be :
		nilnul.obj.Be1<nilnul.num_.Plural1>
		,
		BeI
	{
		public Be(Func<Plural1, bool> func) : base(func)
		{
		}

		public Be(Predicate<Plural1> predicate) : base(predicate)
		{
		}
	}
}
