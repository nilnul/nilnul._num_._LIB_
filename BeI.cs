using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num
{

	[Obsolete()]
	public interface BeI:nilnul.obj.BeI1<nilnul.Num>
	{
	}

	public interface BeI1
		:nilnul.obj.BeI1<NumI1>

	{ }

	/// <summary>
	/// abstract on interfaces
	/// </summary>
	public abstract class BeA : BeI1
	{
		public abstract bool be(NumI1 obj);
		public bool be(Num1 obj) {
			return be(
				(NumI1)obj
			);
		}
	}

}
