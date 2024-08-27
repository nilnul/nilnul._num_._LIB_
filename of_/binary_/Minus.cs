using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.combine_
{
	/// <summary>
	/// may throw exception
	/// </summary>
	public class Minus : nilnul.num.CombineI1
	{
		public NumI combine(NumI arg, NumI arg1)
		{
			return new Num(
				arg.toBigint() -arg1.toBigint()
			);
			//throw new NotImplementedException();
		}


		static public readonly Minus Singleton = nilnul.obj.SingletonByDefault<Minus>.Instance;

	}
}
