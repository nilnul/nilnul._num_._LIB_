using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul.Num;


namespace nilnul.num
{
	public class Trio : Tuple<N, N, N>
	{
		public Trio(N item1, N item2, N item3) : base(item1, item2, item3)
		{

		}
	}
}
