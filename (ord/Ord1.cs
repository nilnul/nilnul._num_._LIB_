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
	public class Ord1
		:
		nilnul.obj.Box<nilnul.Num>
		,
		OrdI1
		,IRank
	{
		public Ord1(Num val) : base(val)
		{
		}

		public Ord1(NumI val):this(new nilnul.Num(val))
		{

		}

		static public implicit operator Ord1(nilnul.Num num) {
			return new Ord1(num);
		}

		static public Ord1 operator ++(nilnul.num.Ord1 num) {
			return new Ord1(num++);
		}


		public Num toNum()
		{
			
				return this.boxed;
				//throw new NotImplementedException();
			
		}
	}
}
