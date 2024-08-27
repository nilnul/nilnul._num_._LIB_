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
	public class Bound<TOrd>
		: nilnul.num.ord.co_.colRow_.sameType.be_.le.vow.En<TOrd>
		
		where TOrd:nilnul.num.OrdI1
	{


		public TOrd lower
		{
			get { return en.Item1; }
		}

		public TOrd upper
		{
			get { return en.Item2; }
		}


		public Closed toNumRange()
		{
			return new Closed(lower.toNum(), upper.toNum());
			//throw new NotImplementedException();
		}

		public Bound(TOrd col1, TOrd col2):this(new co_.colRow_.SameType<TOrd>(col1,col2))
		{
		}

		public Bound(co_.colRow_.SameType<TOrd> val) : base(val)
		{
		}

		public static Bound<TOrd> CreateSingleton(TOrd col)
		{
			return new Bound<TOrd>(col, col);
		}

	

	
	}
}
