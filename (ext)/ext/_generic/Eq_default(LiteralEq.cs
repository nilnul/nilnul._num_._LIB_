using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.ext_._generic
{
	public class Eq_default<TLiteral,LiteralEq, TExtLiteral>
		
		:Eq<TLiteral,LiteralEq,TExtLiteral>

		where LiteralEq :IEqualityComparer<TLiteral>,new()
		where TExtLiteral :num._ext._generic.UnExt<TLiteral>
	{
		
		public Eq_default()
			:base(new LiteralEq())
		{

		}


	}
}
