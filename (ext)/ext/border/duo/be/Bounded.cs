using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ext_.border.duo.be
{
	extern alias bit;
	public class Bounded
		:
		bit::
		nilnul.obj.BeI<Duo>
	{
		static public readonly Nonempty Instance = new Nonempty();

		public bool be(Duo d)
		{
			return Nonempty.Instance.be(d) && d.notContain(Inf.Instance);
			throw new NotImplementedException();
		}

		public class Asserted:nilnul.obj.Asserted1<Duo,Bounded>
		{

			public Asserted(Duo val):base(val)
			{

			}
		}
	}
}
