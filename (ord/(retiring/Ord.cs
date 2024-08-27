using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num
{
	/// <summary>
	/// the cannonical from of ord
	/// </summary>
	/// 
	[Obsolete()]
	public class Ord
		:
		nilnul.obj.Box<nilnul.Num>
		,
		OrdI
	{
		public Ord(Num val) : base(val)
		{
		}

		public Ord(NumI val):this(new nilnul.Num(val))
		{

		}

		public NumI toNum()
		{
			
				return this.boxed;
				//throw new NotImplementedException();
			
		}
	}
}
