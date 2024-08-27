using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ext_.border.duo.be
{
	extern alias bit;
	public class Nonempty1
		:
		bit:: nilnul.obj.BeI<Duo1>
	{
		static public readonly Nonempty1 Instance = new Nonempty1();

		public bool be(Duo1 d)
		{
			var markCompared = ext_.Comparer1.Instance.Compare(d.lower.mark, d.upper.mark);

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
							((d.lower.mark) as Basic ).val+1
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

		public class En:nilnul.obj.Asserted1<Duo1,Nonempty1>
		{

			public En(Duo1 val):base(val)
			{

			}

			public En(Border1 lower, Border1 upper)
				:this(new Duo1(lower, upper))
			{

			}

			
		}
	}
}
