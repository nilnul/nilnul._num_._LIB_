using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ext_.border.duo.be
{
	extern alias bit;
	[Obsolete()]
	public class Nonempty
		:
		bit::
		nilnul.obj.BeI<Duo>
	{
		static public readonly Nonempty Instance = new Nonempty();

		public bool be(Duo d)
		{
			var markCompared = ext_.Comparer.Instance.Compare(d.lower.mark, d.upper.mark);

			if (   d.lower.mark < d.upper.mark)
			{
				if (d.lower.openFalseCloseTrue)
				{
					return true;

				}
				else
				{
					if (d.upper.openFalseCloseTrue)
					{
						return true;
					}
					else
					{
						
						if (
							d.upper.mark
							>
							((d.lower.mark) as Seed ).val+1
						)
						{
							return true;
						}
						else
						{
							return false;

						}
					}
				}

			}
			else if(markCompared==0)
			{
				return d.lower.openFalseCloseTrue && d.upper.openFalseCloseTrue;


			}

			return false;

			throw new NotImplementedException();
		}

		public class Asserted:nilnul.obj.Asserted1<Duo,Nonempty>
		{

			public Asserted(Duo val):base(val)
			{

			}
		}
	}
}
