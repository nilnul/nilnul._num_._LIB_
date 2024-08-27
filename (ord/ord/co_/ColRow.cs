using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.co_
{
	
	


//	[Obsolete(nameof(ord.Co<TCol,TRow>))]
	[Obsolete()]
	public class ColRow<TCol,TRow>
		: Tuple<TCol,TRow>

		where TCol:OrdI1
		where TRow:OrdI1
	{

		public ColRow(TCol x, TRow y): base(x, y)
		{
		}


	}

}
