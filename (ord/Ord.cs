using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num
{
	/// <summary>
	/// the cannonical from of ord, is denoted as numero for differentiating from general Ord which includes one based
	/// </summary>
	/// <remarks>
	/// alias:
	///		numero
	/// </remarks>
	public class Ord2
		:
		nilnul.obj.Box<nilnul.Num1>
		,
		OrdI2
	{

		public Ord2(Num1 val) : base(val)
		{
		}

		public Ord2(NumI1 val):this(new nilnul.Num1(val))
		{

		}

		public Ord2(BigInteger item):this(new Num1(item))
		{
		}

		static public implicit operator Ord2(nilnul.Num1 num) {
			return new Ord2(num);
		}

		static public Ord2 operator ++(nilnul.num.Ord2 num) {
			return new Ord2(num.boxed++);
		}


		public NumI1 toNum()
		{
			
				return this.boxed;
				//throw new NotImplementedException();
			
		}
	}
}
