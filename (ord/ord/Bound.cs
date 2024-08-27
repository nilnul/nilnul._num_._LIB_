using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.range_;

namespace nilnul.num.ord
{
	[Obsolete()]
	public class Bound
		: nilnul.num.ord.co.be_.le.vow.En
		,
		str_.SeqI

	{


		public nilnul.num.OrdI1 lower
		{
			get { return en.Item1; }
		}

		public nilnul.num.OrdI1 upper
		{
			get { return en.Item2; }
		}


		public Closed toNumRange()
		{
			return new Closed(lower.toNum(), upper.toNum());
			//throw new NotImplementedException();
		}

		public Bound(OrdI1 col1, OrdI1 col2):this(new Co(col1,col2))
		{
		}

		public Bound(Co val) : base(val)
		{
		}

		public static Bound CreateSingleton(OrdI1 col)
		{
			return new Bound(col, col);
		}

	

		public IEnumerator<OrdI1> GetEnumerator()
		{
			for (var i = new Ord1( lower.toNum()); ord.comparer.Re.Singleton.le(i, this.upper); i ++)
			{
				yield return i;

			}
			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}
}
