using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.ext_._generic
{
	public class Eq_default_compareLiteral<T, Eq, TBase>
		:
		Eq_default<T,Eq,TBase>


		
		where Eq :IEqualityComparer<T>,  new()
		where TBase :num._ext._generic.UnExt<T>

	{
		
		


	}
}
