using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.str.duo.be
{
	public class Multiplicable
	{

		static public bool Eval<T,T1>(IEnumerable<T> a,IEnumerable<T1> b) {
			return a.Count() == b.Count();

			throw new NotImplementedException();

		}

	}
}
