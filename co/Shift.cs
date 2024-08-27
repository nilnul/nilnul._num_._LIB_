using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.duo
{
	/// <summary>
	/// from one num(point on the real axis) to another. note:1) the num may be the same; 2) the num is not ordered, i.e., may be from lower to upper or reversed
	/// </summary>
	public class Shift : nilnul.Box1<Duo1>
		,
		_shift_.BeginI,_shift_.EndI
	{
		public Num begin
		{
			get
			{
				return this.boxed.Item1;
				throw new NotImplementedException();
			}
		}

		public Num end
		{
			get
			{
				return this.boxed.Item2;
				throw new NotImplementedException();
			}
		}

		public Shift(Duo1 val) : base(val)
		{

		}

		public Shift(Num item11, Num item12):this(new Duo1(item11,item12))
		{
		}

		/// <summary>
		/// pass the given point in the sweeping path
		/// </summary>
		/// <returns></returns>
		public bool contain(Num x) {
			return nilnul.num.Range.CreateClose_sortWhenNecessary(this.boxed).contain(x);
		}

		static public bool Contain(Shift shift, Num num) {
			return nilnul.num.Range.CreateClose_sortWhenNecessary(shift.boxed).contain(num);

		}
	}
}
