using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.ord.co_.colRow_;
using nilnul.num.range_;

namespace nilnul.num.ord
{
	/// <summary>
	/// closed
	/// </summary>
	/// <typeparam name="TOrd"></typeparam>
	public class Bound1<TOrd>
		: nilnul.num.ord.co.be_.le.vow.Ee<TOrd>
		
		where TOrd:nilnul.num.OrdI2
	{


		public TOrd lower
		{
			get { return ee.Item1; }
		}

		public TOrd upper
		{
			get { return ee.Item2; }
		}


		public IEnumerable<BigInteger> enumerateAsBigInt()
		{
			var up = upper.toNum().toBigint().en;
			for (
				BigInteger i = lower.toNum().toBigint(); i <=up; i++
			)
			{
				yield return i;
			}
		}

		public Closed toNumRange()
		{
			return new Closed(lower.toNum(), upper.toNum());
			//throw new NotImplementedException();
		}
		public Bound1(Co<TOrd> val) : base(val)
		{
		}
		public Bound1(co_.colRow_.SameType1<TOrd> val) : this(new Co<TOrd>(val.Item1,val.Item2))
		{
		}


		public Bound1(TOrd col1, TOrd col2):this(new co_.colRow_.SameType1<TOrd>(col1,col2))
		{
		}

		public bool contain(TOrd x) {
			return ord.re_.Le<TOrd>.Singleton.re(lower,x)
				&& ord.re_.Le<TOrd>.Singleton.re(x, upper)
				;
		}

		public static Bound1<TOrd> CreateSingleton(TOrd col)
		{
			return new Bound1<TOrd>(col, col);
		}

	

	
	}

	public class Bound1 : Bound1<nilnul.num.OrdI2>
	{
		public Bound1(SameType1<OrdI2> val) : base(val)
		{
		}

		public Bound1(OrdI2 col1, OrdI2 col2) : base(col1, col2)
		{
		}
	}
}
